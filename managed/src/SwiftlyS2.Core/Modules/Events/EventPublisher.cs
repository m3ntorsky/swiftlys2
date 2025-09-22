using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared.SchemaDefinitions;
using Spectre.Console;
using System.Runtime.CompilerServices;
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.Events;

internal static class EventPublisher {

  private static List<EventSubscriber> _subscribers = new();

  public static void Subscribe(EventSubscriber subscriber) {
    _subscribers.Add(subscriber);
  }
   public static void Unsubscribe(EventSubscriber subscriber) {
    _subscribers.Remove(subscriber);
  }

  public static void Register() {
    unsafe {
      NativeEvents.RegisterOnGameTickCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnTick));
      NativeEvents.RegisterOnClientConnectCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnClientConnected));
      NativeEvents.RegisterOnClientDisconnectCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnClientDisconnected));
      NativeEvents.RegisterOnClientKeyStateChangedCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnClientKeyStateChanged));
      NativeEvents.RegisterOnClientPutInServerCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnClientPutInServer));
      NativeEvents.RegisterOnClientSteamAuthorizeCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnClientSteamAuthorize));
      NativeEvents.RegisterOnClientSteamAuthorizeFailCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnClientSteamAuthorizeFail));
      NativeEvents.RegisterOnEntityCreatedCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnEntityCreated));
      NativeEvents.RegisterOnEntityDeletedCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnEntityDeleted));
      NativeEvents.RegisterOnEntityParentChangedCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnEntityParentChanged));
      NativeEvents.RegisterOnEntitySpawnedCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnEntitySpawned));
      NativeEvents.RegisterOnMapLoadCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnMapLoad));
      NativeEvents.RegisterOnMapUnloadCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnMapUnload));
      NativeEvents.RegisterOnClientProcessUsercmdsCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnClientProcessUsercmds));
      NativeEvents.RegisterOnEntityTakeDamageCallback(Marshal.GetFunctionPointerForDelegate(_unmanagedOnEntityTakeDamage));
    }
  }


  delegate void OnTickDelegate(bool simulating, bool first, bool last);
  private static OnTickDelegate _unmanagedOnTick = OnTick;

  delegate bool OnClientConnectedDelegate(int playerId);
  private static OnClientConnectedDelegate _unmanagedOnClientConnected = OnClientConnected;
  delegate void OnClientDisconnectedDelegate(int playerId, int reason);
  private static OnClientDisconnectedDelegate _unmanagedOnClientDisconnected = OnClientDisconnected;
  delegate void OnClientKeyStateChangedDelegate(int playerId, GameKeyKind key, bool pressed);
  private static OnClientKeyStateChangedDelegate _unmanagedOnClientKeyStateChanged = OnClientKeyStateChanged;
  delegate void OnClientPutInServerDelegate(int playerId, int clientKind);
  private static OnClientPutInServerDelegate _unmanagedOnClientPutInServer = OnClientPutInServer;
  delegate void OnClientSteamAuthorizeDelegate(int playerId);
  private static OnClientSteamAuthorizeDelegate _unmanagedOnClientSteamAuthorize = OnClientSteamAuthorize;
  delegate void OnClientSteamAuthorizeFailDelegate(int playerId);
  private static OnClientSteamAuthorizeFailDelegate _unmanagedOnClientSteamAuthorizeFail = OnClientSteamAuthorizeFail;
  delegate void OnEntityCreatedDelegate(nint entityPtr);
  private static OnEntityCreatedDelegate _unmanagedOnEntityCreated = OnEntityCreated;
  delegate void OnEntityDeletedDelegate(nint entityPtr);
  private static OnEntityDeletedDelegate _unmanagedOnEntityDeleted = OnEntityDeleted;
  delegate void OnEntityParentChangedDelegate(nint entityPtr, nint newParentPtr);
  private static OnEntityParentChangedDelegate _unmanagedOnEntityParentChanged = OnEntityParentChanged;
  delegate void OnEntitySpawnedDelegate(nint entityPtr);
  private static OnEntitySpawnedDelegate _unmanagedOnEntitySpawned = OnEntitySpawned;
  delegate void OnMapLoadDelegate(nint mapNamePtr);
  private static OnMapLoadDelegate _unmanagedOnMapLoad = OnMapLoad;
  delegate void OnMapUnloadDelegate(nint mapNamePtr);
  private static OnMapUnloadDelegate _unmanagedOnMapUnload = OnMapUnload;
  delegate void OnClientProcessUsercmdsDelegate(int playerId, nint usercmdsPtr, int numcmds, bool paused, float margin);
  private static OnClientProcessUsercmdsDelegate _unmanagedOnClientProcessUsercmds = OnClientProcessUsercmds;
  delegate bool OnEntityTakeDamageDelegate(nint entityPtr, nint takeDamageInfoPtr);
  private static OnEntityTakeDamageDelegate _unmanagedOnEntityTakeDamage = OnEntityTakeDamage;

  public static void OnTick(bool simulating, bool first, bool last)
  {
    if (_subscribers.Count == 0) return;
    try {
      _subscribers.ForEach(subscriber => subscriber.InvokeOnTick());
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static bool OnClientConnected(int playerId)
  {
    if (_subscribers.Count == 0) return true;
    try { 
    OnClientConnectedEvent @event = new() {
      PlayerId = playerId
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnClientConnected(@event);

      if (@event.Result == HookResult.Handled)
      {
        return true;
      }

      if (@event.Result == HookResult.Stop)
      {
        return false;
      }
      }

      return true;
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
      return true;
    }
  }

  public static void OnClientDisconnected(int playerId, int reason)
  {
    if (_subscribers.Count == 0) return;
    try {
    OnClientDisconnectedEvent @event = new() {
      PlayerId = playerId,
      Reason = (ENetworkDisconnectionReason)reason
    };

    foreach (var subscriber in _subscribers)
    {
        subscriber.InvokeOnClientDisconnected(@event);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnClientKeyStateChanged(int playerId, GameKeyKind key, bool pressed)
  {
    if (_subscribers.Count == 0) return;
    try {
    OnClientKeyStateChangedEvent @event = new() {
      PlayerId = playerId,
      Key = key.ToKeyKind(),
      Pressed = pressed
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnClientKeyStateChanged(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnClientPutInServer(int playerId, int clientKind)
  {
    if (_subscribers.Count == 0) return;
    try {
    OnClientPutInServerEvent @event = new() {
      PlayerId = playerId,
      Kind = (ClientKind)clientKind
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnClientPutInServer(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnClientSteamAuthorize(int playerId)
  {
    if (_subscribers.Count == 0) return;
    try {
    OnClientSteamAuthorizeEvent @event = new() {
      PlayerId = playerId
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnClientSteamAuthorize(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnClientSteamAuthorizeFail(int playerId)
  {
    if (_subscribers.Count == 0) return;
    try {
    OnClientSteamAuthorizeFailEvent @event = new() {
      PlayerId = playerId
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnClientSteamAuthorizeFail(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnEntityCreated(nint entityPtr)
  {
    if (_subscribers.Count == 0) return;
    try {
    var entity = new CEntityInstanceImpl(entityPtr);
    OnEntityCreatedEvent @event = new() {
      Entity = entity
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnEntityCreated(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnEntityDeleted(nint entityPtr)
  {
    if (_subscribers.Count == 0) return;
    try {
    var entity = new CEntityInstanceImpl(entityPtr);
    OnEntityDeletedEvent @event = new() {
      Entity = entity
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnEntityDeleted(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnEntityParentChanged(nint entityPtr, nint newParentPtr)
  {
    if (_subscribers.Count == 0) return;
    try {
    var entity = new CEntityInstanceImpl(entityPtr);
    CEntityInstance? parent = newParentPtr != 0 ? new CEntityInstanceImpl(newParentPtr) : null;
    OnEntityParentChangedEvent @event = new() {
      Entity = entity,
      NewParent = parent
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnEntityParentChanged(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnEntitySpawned(nint entityPtr)
  { 
    if (_subscribers.Count == 0) return;
    try {
    var entity = new CEntityInstanceImpl(entityPtr);
    OnEntitySpawnedEvent @event = new() {
      Entity = entity
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnEntitySpawned(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnMapLoad(nint mapNamePtr)
  {
    if (_subscribers.Count == 0) return;
    try {
    string map = Marshal.PtrToStringUTF8(mapNamePtr) ?? string.Empty;
    OnMapLoadEvent @event = new() {
      MapName = map
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnMapLoad(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnMapUnload(nint mapNamePtr)
  {
    if (_subscribers.Count == 0) return;
    try {
    string map = Marshal.PtrToStringUTF8(mapNamePtr) ?? string.Empty;
    OnMapUnloadEvent @event = new() {
      MapName = map
    };
    foreach (var subscriber in _subscribers)
    {
      subscriber.InvokeOnMapUnload(@event);
    }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static void OnClientProcessUsercmds(int playerId, nint usercmdsPtr, int numcmds, bool paused, float margin) {
    if (_subscribers.Count == 0) return;
    try {
      unsafe {
        ReadOnlySpan<nint> usercmdPtrs = new ReadOnlySpan<nint>(usercmdsPtr.ToPointer(), numcmds);
        List<CSGOUserCmdPB> usercmds = new();
        foreach (var pUsercmd in usercmdPtrs) {
          var usercmd = new CSGOUserCmdPBImpl(pUsercmd, false);
          usercmds.Add(usercmd);
        }

        OnClientProcessUsercmdsEvent @event = new() {
          PlayerId = playerId,
          Usercmds = usercmds,
          Paused = paused,
          Margin = margin
        };
        foreach (var subscriber in _subscribers) {
          subscriber.InvokeOnClientProcessUsercmds(@event);
        }
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public static bool OnEntityTakeDamage(nint entityPtr, nint takeDamageInfoPtr) {
    if (_subscribers.Count == 0) return true;
    try {
      unsafe {
        var entity = new CEntityInstanceImpl(entityPtr);
        OnEntityTakeDamageEvent @event = new() {
          Entity = entity,
          _infoPtr = takeDamageInfoPtr
        };
        foreach (var subscriber in _subscribers) {
          subscriber.InvokeOnEntityTakeDamage(@event);

          if (@event.Result == HookResult.Handled) {
            return true;
          }

          if (@event.Result == HookResult.Stop) {
            return false;
          }
        }
        return true;
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
      return true;
    }
  }
}