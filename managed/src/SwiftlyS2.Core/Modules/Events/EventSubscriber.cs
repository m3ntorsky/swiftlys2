using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Profiler;

namespace SwiftlyS2.Core.Events;

/// <summary>
/// Plugin-scoped custom event subscriber.
/// </summary>
internal class EventSubscriber : IEventSubscriber, IDisposable {

  private CoreContext _Id { get; init; }
  private IContextedProfilerService _Profiler { get; init; }
  private ILogger<EventSubscriber> _Logger { get; init; }

  public EventSubscriber(CoreContext id, IContextedProfilerService profiler, ILogger<EventSubscriber> logger) {
    _Id = id;
    _Profiler = profiler;
    _Logger = logger;
    EventPublisher.Subscribe(this);
  }

  public event EventDelegates.OnTick? OnTick;

  public event EventDelegates.OnClientConnected? OnClientConnected;

  public event EventDelegates.OnClientDisconnected? OnClientDisconnected;
  public event EventDelegates.OnClientKeyStateChanged? OnClientKeyStateChanged;
  public event EventDelegates.OnClientPutInServer? OnClientPutInServer;
  public event EventDelegates.OnClientSteamAuthorize? OnClientSteamAuthorize;
  public event EventDelegates.OnClientSteamAuthorizeFail? OnClientSteamAuthorizeFail;
  public event EventDelegates.OnEntityCreated? OnEntityCreated;
  public event EventDelegates.OnEntityDeleted? OnEntityDeleted;
  public event EventDelegates.OnEntityParentChanged? OnEntityParentChanged;
  public event EventDelegates.OnEntitySpawned? OnEntitySpawned;
  public event EventDelegates.OnMapLoad? OnMapLoad;
  public event EventDelegates.OnMapUnload? OnMapUnload;
  public event EventDelegates.OnClientProcessUsercmds? OnClientProcessUsercmds;
  public event EventDelegates.OnEntityTakeDamage? OnEntityTakeDamage;

  public void Dispose() {
    EventPublisher.Unsubscribe(this);
  }

  public void InvokeOnTick()
  {
    try
    {
      _Profiler.StartRecording("Event::OnTick");
      OnTick?.Invoke();
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnTick.");
    } finally {
      _Profiler.StopRecording("Event::OnTick");
    }
  }

  public void InvokeOnClientConnected(OnClientConnectedEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnClientConnected");
      OnClientConnected?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnClientConnected.");
    } finally {
      _Profiler.StopRecording("Event::OnClientConnected");
    }
  }

  public void InvokeOnClientDisconnected(OnClientDisconnectedEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnClientDisconnected");
      OnClientDisconnected?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnClientDisconnected.");
    } finally {
      _Profiler.StopRecording("Event::OnClientDisconnected");
    }
  }

  public void InvokeOnClientKeyStateChanged(OnClientKeyStateChangedEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnClientKeyStateChanged");
      OnClientKeyStateChanged?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnClientKeyStateChanged.");
    } finally {
      _Profiler.StopRecording("Event::OnClientKeyStateChanged");
    }
  }

  public void InvokeOnClientPutInServer(OnClientPutInServerEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnClientPutInServer");
      OnClientPutInServer?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnClientPutInServer.");
    } finally {
      _Profiler.StopRecording("Event::OnClientPutInServer");
    }
  }

  public void InvokeOnClientSteamAuthorize(OnClientSteamAuthorizeEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnClientSteamAuthorize");
      OnClientSteamAuthorize?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnClientSteamAuthorize.");
    } finally {
      _Profiler.StopRecording("Event::OnClientSteamAuthorize");
    }
  }

  public void InvokeOnClientSteamAuthorizeFail(OnClientSteamAuthorizeFailEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnClientSteamAuthorizeFail");
      OnClientSteamAuthorizeFail?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnClientSteamAuthorizeFail.");
    } finally {
      _Profiler.StopRecording("Event::OnClientSteamAuthorizeFail");
    }
  }

  public void InvokeOnEntityCreated(OnEntityCreatedEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnEntityCreated");
      OnEntityCreated?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnEntityCreated.");
    } finally {
      _Profiler.StopRecording("Event::OnEntityCreated");
    }
  }

  public void InvokeOnEntityDeleted(OnEntityDeletedEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnEntityDeleted");
      OnEntityDeleted?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnEntityDeleted.");
    } finally {
      _Profiler.StopRecording("Event::OnEntityDeleted");
    }
  }

  public void InvokeOnEntityParentChanged(OnEntityParentChangedEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnEntityParentChanged");
      OnEntityParentChanged?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnEntityParentChanged.");
    } finally {
      _Profiler.StopRecording("Event::OnEntityParentChanged");
    }
  }

  public void InvokeOnEntitySpawned(OnEntitySpawnedEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnEntitySpawned");
      OnEntitySpawned?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnEntitySpawned.");
    } finally {
      _Profiler.StopRecording("Event::OnEntitySpawned");
    }
  }

  public void InvokeOnMapLoad(OnMapLoadEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnMapLoad");
      OnMapLoad?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnMapLoad.");
    } finally {
      _Profiler.StopRecording("Event::OnMapLoad");
    }
  }

  public void InvokeOnMapUnload(OnMapUnloadEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnMapUnload");
      OnMapUnload?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnMapUnload.");
    } finally {
      _Profiler.StopRecording("Event::OnMapUnload");
    }
  }

  public void InvokeOnClientProcessUsercmds(OnClientProcessUsercmdsEvent ev) {
    try {
      _Profiler.StartRecording("Event::OnClientProcessUsercmds");
      OnClientProcessUsercmds?.Invoke(ev);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnClientProcessUsercmds.");
    } finally {
      _Profiler.StopRecording("Event::OnClientProcessUsercmds");
    }
  }

  public void InvokeOnEntityTakeDamage(OnEntityTakeDamageEvent @event) {
    try {
      _Profiler.StartRecording("Event::OnEntityTakeDamage");
      OnEntityTakeDamage?.Invoke(@event);
    } catch (Exception e) {
      _Logger.LogError(e, "Error invoking OnEntityTakeDamage.");
    } finally {
      _Profiler.StopRecording("Event::OnEntityTakeDamage");
    }
  }

}