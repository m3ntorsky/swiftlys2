using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.GameEvents;

internal abstract class GameEvent<T> : AllocableNativeHandle where T : IGameEvent<T> {

  public bool DontBroadcast { get; set; }

  internal GameEvent(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated) {
  }

  public void Fire() => NativeGameEvents.FireEvent(GetHandle(), DontBroadcast);

  public void FireToClient(int clientId) => NativeGameEvents.FireEventToClient(GetHandle(), clientId);

  protected override bool Free() {
    NativeGameEvents.FreeEvent(GetHandle());
    return true;
  }

  public void SetBool(string key, bool value) => NativeGameEvents.SetBool(GetHandle(), key, value);

  public bool GetBool(string key) => NativeGameEvents.GetBool(GetHandle(), key);

  public void SetInt(string key, int value) => NativeGameEvents.SetInt(GetHandle(), key, value);

  public int GetInt(string key) => NativeGameEvents.GetInt(GetHandle(), key);

  public void SetUint64(string key, ulong value) => NativeGameEvents.SetUint64(GetHandle(), key, value);

  public ulong GetUint64(string key) => NativeGameEvents.GetUint64(GetHandle(), key);

  public void SetFloat(string key, float value) => NativeGameEvents.SetFloat(GetHandle(), key, value);

  public float GetFloat(string key) => NativeGameEvents.GetFloat(GetHandle(), key);

  public void SetString(string key, string value) => NativeGameEvents.SetString(GetHandle(), key, value);

  public string GetString(string key) => NativeGameEvents.GetString(GetHandle(), key);

  public void SetEntity<K>(string key, K value) where K : CEntityInstance => NativeGameEvents.SetEntity(GetHandle(), key, value.GetHandle());

  public K GetEntity<K>(string key) where K : CEntityInstance => (K)K.From(NativeGameEvents.GetEntity(GetHandle(), key));

  public void SetEntityIndex(string key, int value) => NativeGameEvents.SetEntityIndex(GetHandle(), key, value);

  public int GetEntityIndex(string key) => NativeGameEvents.GetEntityIndex(GetHandle(), key);

  public void SetPlayerSlot(string key, int value) => NativeGameEvents.SetPlayerSlot(GetHandle(), key, value);

  public int GetPlayerSlot(string key) => NativeGameEvents.GetPlayerSlot(GetHandle(), key);

  public CCSPlayerController GetPlayerController(string key) => new CCSPlayerControllerImpl(NativeGameEvents.GetPlayerController(GetHandle(), key));

  public CCSPlayerPawn GetPlayerPawn(string key) => new CCSPlayerPawnImpl(NativeGameEvents.GetPlayerPawn(GetHandle(), key));

  public void SetPtr(string key, nint value) => NativeGameEvents.SetPtr(GetHandle(), key, value);

  public nint GetPtr(string key) => NativeGameEvents.GetPtr(GetHandle(), key);

  public int GetPawnEntityIndex(string key) => NativeGameEvents.GetPawnEntityIndex(GetHandle(), key);

  public bool IsReliable() => NativeGameEvents.IsReliable(GetHandle());

  public bool IsLocal() => NativeGameEvents.IsLocal(GetHandle());

  
}
