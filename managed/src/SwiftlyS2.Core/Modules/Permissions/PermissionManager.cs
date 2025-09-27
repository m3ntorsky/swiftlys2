using System.Collections.Concurrent;
using System.Collections.Immutable;
using Spectre.Console;
using SwiftlyS2.Shared.Permissions;

namespace SwiftlyS2.Core.Permissions;

internal class PermissionManager : IPermissionManager {

  private Dictionary<ulong, List<string>> _permissions = new();
  private Dictionary<string, List<string>> _subPermissions = new();
  private ImmutableDictionary<PermissionCacheKey, bool> _queryCache = ImmutableDictionary.Create<PermissionCacheKey, bool>();
  private object _lock = new();

  public PermissionManager() {
    LoadPermissions();
  } 

  private void LoadPermissions() {
    // TODO: load permissions config from file
  }

  private bool IsEqual(string from, string target) {
    if (from == "*") {
      return true;
    }
    if (!from.Contains("*")) {
      return string.Equals(from, target, StringComparison.OrdinalIgnoreCase);
    }

    var prefix = from[..^2];
    return target.StartsWith(prefix, StringComparison.OrdinalIgnoreCase);
  }

  private bool HasNestedPermission(string rootPermission, string targetPermission, List<string> visitedPermissions) {
    if(visitedPermissions.Contains(rootPermission)) {
      AnsiConsole.WriteLine("Loop detected for permission: " + rootPermission);
      return false;
    }

    visitedPermissions.Add(rootPermission);

    if(IsEqual(rootPermission, targetPermission)) {
      return true;
    }

    if(_subPermissions.TryGetValue(rootPermission, out var subPermissions)) {
      foreach(var subPermission in subPermissions) {
        if(HasNestedPermission(subPermission, targetPermission, visitedPermissions)) {
          return true;
        }
      }
    }

    return false;
  }

  public bool PlayerHasPermission(ulong playerId, string permission) {
    var key = new PermissionCacheKey { PlayerId = playerId, Permission = permission };
    if(_queryCache.TryGetValue(key, out var result)) {
      return result;
    }

    lock(_lock)
    {
      if (!_permissions.TryGetValue(playerId, out var permissions))
      {
        _queryCache = _queryCache.Add(key, false);
        return false;
      }

      if (permissions.Any(p => IsEqual(p, permission)))
      {
        _queryCache = _queryCache.Add(key, true);
        return true;
      }

      foreach (var perm in permissions)
      {
        if (HasNestedPermission(perm, permission, new List<string>()))
        {
          _queryCache = _queryCache.Add(key, true);
          return true;
        }
      }

      _queryCache = _queryCache.Add(key, false);
      return false;
    }

  }

  public void AddPermission(ulong playerId, string permission) {
    lock(_lock) {
      if(!_permissions.TryGetValue(playerId, out var permissions)) {
        permissions = [permission];
        _permissions[playerId] = permissions;
      }
      else if(!permissions.Contains(permission)) {
        permissions.Add(permission);
      }

      _queryCache = _queryCache.Clear();
    }
  }

  public void RemovePermission(ulong playerId, string permission) {
    lock(_lock) {
      if(!_permissions.TryGetValue(playerId, out var permissions)) {
        return;
      }

      permissions.Remove(permission);
    }

    _queryCache = _queryCache.Clear();
  }

  public void AddSubPermission(string permission, string subPermission) {
    lock(_lock) {
      if(!_subPermissions.TryGetValue(permission, out var subPermissions)) {
        subPermissions = [subPermission];
        _subPermissions[permission] = subPermissions;
      }
      else if(!subPermissions.Contains(subPermission)) {
        subPermissions.Add(subPermission);
      } 
    }
    _queryCache = _queryCache.Clear();
  }

  public void RemoveSubPermission(string permission, string subPermission) {
    lock(_lock) {
      if(!_subPermissions.TryGetValue(permission, out var subPermissions)) {
        return;
      }

      subPermissions.Remove(subPermission);
    }

    _queryCache = _queryCache.Clear();
  }
}