using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.GameEvents;

internal class GameEvent : AllocableNativeHandle, IGameEvent {

  public bool DontBroadcast { get; set; }

  private bool _IsFired { get; set; } = false;

  private void CheckIsValid() {
    if (_IsFired) throw new InvalidOperationException("Re-using a fired event is not allowed.");
  }

  internal GameEvent(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated) {
  }

  public void Fire() {
    CheckIsValid();
    NativeGameEvents.FireEvent(GetHandle(), DontBroadcast);
    _IsFired = true;
  }

  public void FireToClient(int clientId) {
    CheckIsValid();
    NativeGameEvents.FireEventToClient(GetHandle(), clientId);
    // _IsFired = true;
  }

  protected override bool Free() {
    if (_IsFired) return true;;
    NativeGameEvents.FreeEvent(GetHandle());
    return true;
  }

  public void SetBool(string key, bool value) {
    CheckIsValid();
    NativeGameEvents.SetBool(GetHandle(), key, value);
  }

  public bool GetBool(string key) {
    CheckIsValid();
    return NativeGameEvents.GetBool(GetHandle(), key);
  }

  public void SetInt32(string key, int value) {
    CheckIsValid();
    NativeGameEvents.SetInt(GetHandle(), key, value);
  }

  public int GetInt32(string key) {
    CheckIsValid();
    return NativeGameEvents.GetInt(GetHandle(), key);
  }

  public void SetUInt64(string key, ulong value) {
    CheckIsValid();
    NativeGameEvents.SetUint64(GetHandle(), key, value);
  }

  public ulong GetUInt64(string key) {
    CheckIsValid();
    return NativeGameEvents.GetUint64(GetHandle(), key);
  }

  public void SetFloat(string key, float value) {
    CheckIsValid();
    NativeGameEvents.SetFloat(GetHandle(), key, value);
  }

  public float GetFloat(string key) {
    CheckIsValid();
    return NativeGameEvents.GetFloat(GetHandle(), key);
  }

  public void SetString(string key, string value) {
    CheckIsValid();
    NativeGameEvents.SetString(GetHandle(), key, value);
  }

  public string GetString(string key) {
    CheckIsValid();
    return NativeGameEvents.GetString(GetHandle(), key);
  }

  public void SetEntity<K>(string key, K value) where K : CEntityInstance {
    CheckIsValid();
    NativeGameEvents.SetEntity(GetHandle(), key, value.GetHandle());
  }

  public K GetEntity<K>(string key) where K : CEntityInstance {
    CheckIsValid();
    return (K)K.From(NativeGameEvents.GetEntity(GetHandle(), key));
  }

  public void SetEntityIndex(string key, int value) {
    CheckIsValid();
    NativeGameEvents.SetEntityIndex(GetHandle(), key, value);
  }

  public int GetEntityIndex(string key) {
    CheckIsValid();
    return NativeGameEvents.GetEntityIndex(GetHandle(), key);
  }

  public void SetPlayerSlot(string key, int value) {
    CheckIsValid();
    NativeGameEvents.SetPlayerSlot(GetHandle(), key, value);
  }

  public int GetPlayerSlot(string key) {
    CheckIsValid();
    return NativeGameEvents.GetPlayerSlot(GetHandle(), key);
  }

  public CCSPlayerController GetPlayerController(string key) {
    CheckIsValid();
    return new CCSPlayerControllerImpl(NativeGameEvents.GetPlayerController(GetHandle(), key));
  }

  public CCSPlayerPawn GetPlayerPawn(string key) {
    CheckIsValid();
    return new CCSPlayerPawnImpl(NativeGameEvents.GetPlayerPawn(GetHandle(), key));
  }

  public void SetPtr(string key, nint value) {
    CheckIsValid();
    NativeGameEvents.SetPtr(GetHandle(), key, value);
  }

  public nint GetPtr(string key) {
    CheckIsValid();
    return NativeGameEvents.GetPtr(GetHandle(), key);
  }

  public int GetPawnEntityIndex(string key) {
    CheckIsValid();
    return NativeGameEvents.GetPawnEntityIndex(GetHandle(), key);
  }

  public bool IsReliable() {
    CheckIsValid();
    return NativeGameEvents.IsReliable(GetHandle());
  }

  public bool IsLocal() {
    CheckIsValid();
    return NativeGameEvents.IsLocal(GetHandle());
  }

  
}
