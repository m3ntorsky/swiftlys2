using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Managers;
using SwiftlyS2.Shared.Hooks;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.Hooks;

internal class HookService : IHookService {

  private HookManager _HookManager { get; init; }
  private ILogger<HookService> _Logger { get; init; }
  private readonly List<Guid> _ownedHooks = new();
  private int _disposed;

  public HookService(HookManager manager, ILogger<HookService> logger) {
    _HookManager = manager;
    _Logger = logger;
    _disposed = 0;
  }

  public Guid Hook<TDelegate>(nint functionAddress, Func<Func<TDelegate>, TDelegate> callbackBuilder) where TDelegate : Delegate {
    try {
      var id = _HookManager.AddHook(functionAddress, (builder) => callbackBuilder(() => Marshal.GetDelegateForFunctionPointer<TDelegate>(builder())));
      _ownedHooks.Add(id);
      return id;
    } catch (Exception e) {
      _Logger.LogError(e, "Failed to hook function {0}.", functionAddress);
      return Guid.Empty;
    }
  }

  public Guid VHook<TDelegate>(nint vtableAddress, int index, Func<Func<TDelegate>, TDelegate> callbackBuilder) where TDelegate : Delegate {
    try {
      var funcAddress = vtableAddress.Read<nint>(index * IntPtr.Size);
      var id = _HookManager.AddHook(funcAddress, (builder) => callbackBuilder(() => Marshal.GetDelegateForFunctionPointer<TDelegate>(builder())));
      _ownedHooks.Add(id);
      return id;
    } catch (Exception e) {
      _Logger.LogError(e, "Failed to hook vtable {0}.", vtableAddress);
      return Guid.Empty;
    }
  }

  public void Unhook(Guid nodeId) {
    try {
    if (_ownedHooks.Contains(nodeId)) {
      _ownedHooks.Remove(nodeId);
        _HookManager.Remove(new List<Guid> { nodeId });
      }
    } catch (Exception e) {
      _Logger.LogError(e, "Failed to unhook {0}.", nodeId);
    }
  }

  public void Dispose() {
    try {
      _HookManager.Remove(_ownedHooks);
      _ownedHooks.Clear();
    } catch (Exception e) {
      _Logger.LogError(e, "Failed to dispose hook service.");
    }
  }

  // public void Dispose() {
  //   if (Interlocked.Exchange(ref _disposed, 1) != 0) return;
  //   // Remove all owned nodes and rebuild chains accordingly
  //   _manager.RemoveByOwner(this);
  //   foreach (var d in _ownedHooks) {
  //     try { d.Dispose(); } catch { }
  //   }
  //   _ownedHooks.Clear();
  // }

  // private void EnsureNotDisposed() {
  //   if (_disposed != 0) throw new ObjectDisposedException(nameof(HookService));
  // }
} 