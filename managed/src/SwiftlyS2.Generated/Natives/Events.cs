#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeEvents {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnGameTickCallback;
  /// <summary>
  /// bool simulating, bool first, bool last -> void
  /// </summary>
  public unsafe static void RegisterOnGameTickCallback(nint callback) {
    try {
    _RegisterOnGameTickCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnClientConnectCallback;
  /// <summary>
  /// int32 playerid -> bool (true -> ignored, false -> supercede)
  /// </summary>
  public unsafe static void RegisterOnClientConnectCallback(nint callback) {
    try {
    _RegisterOnClientConnectCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnClientDisconnectCallback;
  /// <summary>
  /// int32 playerid, ENetworkDisconnectReason (int32) reason -> void
  /// </summary>
  public unsafe static void RegisterOnClientDisconnectCallback(nint callback) {
    try {
    _RegisterOnClientDisconnectCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnClientKeyStateChangedCallback;
  /// <summary>
  /// int32 playerid, string key, bool pressed -> void
  /// </summary>
  public unsafe static void RegisterOnClientKeyStateChangedCallback(nint callback) {
    try {
    _RegisterOnClientKeyStateChangedCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnClientProcessUsercmdsCallback;
  /// <summary>
  /// int32 playerid, ptr* usercmds, int numcmds, bool paused, float margin -> void
  /// </summary>
  public unsafe static void RegisterOnClientProcessUsercmdsCallback(nint callback) {
    try {
    _RegisterOnClientProcessUsercmdsCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnClientPutInServerCallback;
  /// <summary>
  /// int32 playerid, int32 client_kind (0 -> player, 1 -> bot, 2 -> unknown) -> void
  /// </summary>
  public unsafe static void RegisterOnClientPutInServerCallback(nint callback) {
    try {
    _RegisterOnClientPutInServerCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnClientSteamAuthorizeCallback;
  /// <summary>
  /// int32 playerid -> void
  /// </summary>
  public unsafe static void RegisterOnClientSteamAuthorizeCallback(nint callback) {
    try {
    _RegisterOnClientSteamAuthorizeCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnClientSteamAuthorizeFailCallback;
  /// <summary>
  /// int32 playerid -> void
  /// </summary>
  public unsafe static void RegisterOnClientSteamAuthorizeFailCallback(nint callback) {
    try {
    _RegisterOnClientSteamAuthorizeFailCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnEntityCreatedCallback;
  /// <summary>
  /// CEntityInstance* entity
  /// </summary>
  public unsafe static void RegisterOnEntityCreatedCallback(nint callback) {
    try {
    _RegisterOnEntityCreatedCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnEntityDeletedCallback;
  /// <summary>
  /// CEntityInstance* entity
  /// </summary>
  public unsafe static void RegisterOnEntityDeletedCallback(nint callback) {
    try {
    _RegisterOnEntityDeletedCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnEntityParentChangedCallback;
  /// <summary>
  /// CEntityInstance* entity, CEntityInstance* newparent
  /// </summary>
  public unsafe static void RegisterOnEntityParentChangedCallback(nint callback) {
    try {
    _RegisterOnEntityParentChangedCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnEntitySpawnedCallback;
  /// <summary>
  /// CEntityInstance* entity
  /// </summary>
  public unsafe static void RegisterOnEntitySpawnedCallback(nint callback) {
    try {
    _RegisterOnEntitySpawnedCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnMapLoadCallback;
  /// <summary>
  /// string mapname
  /// </summary>
  public unsafe static void RegisterOnMapLoadCallback(nint callback) {
    try {
    _RegisterOnMapLoadCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnMapUnloadCallback;
  /// <summary>
  /// string mapname
  /// </summary>
  public unsafe static void RegisterOnMapUnloadCallback(nint callback) {
    try {
    _RegisterOnMapUnloadCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _RegisterOnPlayerTakeDamageCallback;
  /// <summary>
  /// int32 playerid, CTakeDamageInfo* info -> bool (true -> ignored, false -> supercede)
  /// </summary>
  public unsafe static void RegisterOnPlayerTakeDamageCallback(nint callback) {
    try {
    _RegisterOnPlayerTakeDamageCallback(callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
