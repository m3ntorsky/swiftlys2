#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeGameEvents {
  private unsafe static delegate* unmanaged<void*, byte*, bool> _GetBool;
  public unsafe static bool GetBool(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetBool(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int> _GetInt;
  public unsafe static int GetInt(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetInt(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, ulong> _GetUint64;
  public unsafe static ulong GetUint64(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetUint64(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, float> _GetFloat;
  public unsafe static float GetFloat(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetFloat(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, byte*, int> _GetString;
  public unsafe static string GetString(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetString(null, event, keyBufferPtr);

    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetString(retBufferPtr, event, keyBufferPtr);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    pool.Return(keyBuffer);

    return retString;
  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _GetPtr;
  public unsafe static void* GetPtr(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetPtr(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _GetEHandle;
  /// <summary>
  /// returns the pointer stored inside the handle
  /// </summary>
  public unsafe static void* GetEHandle(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetEHandle(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _GetEntity;
  public unsafe static void* GetEntity(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetEntity(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int> _GetEntityIndex;
  public unsafe static int GetEntityIndex(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetEntityIndex(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int> _GetPlayerSlot;
  public unsafe static int GetPlayerSlot(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetPlayerSlot(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _GetPlayerController;
  public unsafe static void* GetPlayerController(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetPlayerController(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _GetPlayerPawn;
  public unsafe static void* GetPlayerPawn(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetPlayerPawn(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _GetPawnEHandle;
  /// <summary>
  /// returns the pointer stored inside the handle
  /// </summary>
  public unsafe static void* GetPawnEHandle(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetPawnEHandle(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int> _GetPawnEntityIndex;
  public unsafe static int GetPawnEntityIndex(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _GetPawnEntityIndex(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool, void> _SetBool;
  public unsafe static void SetBool(void* event, string key, bool value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetBool(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, void> _SetInt;
  public unsafe static void SetInt(void* event, string key, int value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetInt(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, ulong, void> _SetUint64;
  public unsafe static void SetUint64(void* event, string key, ulong value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetUint64(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, float, void> _SetFloat;
  public unsafe static void SetFloat(void* event, string key, float value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetFloat(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, byte*, void> _SetString;
  public unsafe static void SetString(void* event, string key, string value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {

    var valueLength = Encoding.UTF8.GetByteCount(value);
    var valueBuffer = pool.Rent(valueLength + 1);
    Encoding.UTF8.GetBytes(value, valueBuffer);
    valueBuffer[valueLength] = 0;
    fixed (byte* valueBufferPtr = valueBuffer) {
    _SetString(event, keyBufferPtr, valueBufferPtr);
    pool.Return(keyBuffer);

    pool.Return(valueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void> _SetPtr;
  public unsafe static void SetPtr(void* event, string key, void* value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetPtr(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void> _SetEntity;
  public unsafe static void SetEntity(void* event, string key, void* value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetEntity(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, void> _SetEntityIndex;
  public unsafe static void SetEntityIndex(void* event, string key, int value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetEntityIndex(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, void> _SetPlayerSlot;
  public unsafe static void SetPlayerSlot(void* event, string key, int value) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _SetPlayerSlot(event, keyBufferPtr, value);
    pool.Return(keyBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool> _HasKey;
  public unsafe static bool HasKey(void* event, string key) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _HasKey(event, keyBufferPtr);
    pool.Return(keyBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, bool> _IsReliable;
  public unsafe static bool IsReliable(void* event) {
    var ret = _IsReliable(event);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, bool> _IsLocal;
  public unsafe static bool IsLocal(void* event) {
    var ret = _IsLocal(event);
    return ret;
  }
  private unsafe static delegate* unmanaged<byte*, void> _RegisterListener;
  public unsafe static void RegisterListener(string eventName) {
    var pool = ArrayPool<byte>.Shared;
    var eventNameLength = Encoding.UTF8.GetByteCount(eventName);
    var eventNameBuffer = pool.Rent(eventNameLength + 1);
    Encoding.UTF8.GetBytes(eventName, eventNameBuffer);
    eventNameBuffer[eventNameLength] = 0;
    fixed (byte* eventNameBufferPtr = eventNameBuffer) {
    _RegisterListener(eventNameBufferPtr);
    pool.Return(eventNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, ulong> _AddListenerPreCallback;
  /// <summary>
  /// the callback should receive the following: uint64 hash, IntPtr gameEvent, bool* dontBroadcast, return bool (true -> ignored, false -> supercede)
  /// </summary>
  public unsafe static ulong AddListenerPreCallback(string eventName, void* callback) {
    var pool = ArrayPool<byte>.Shared;
    var eventNameLength = Encoding.UTF8.GetByteCount(eventName);
    var eventNameBuffer = pool.Rent(eventNameLength + 1);
    Encoding.UTF8.GetBytes(eventName, eventNameBuffer);
    eventNameBuffer[eventNameLength] = 0;
    fixed (byte* eventNameBufferPtr = eventNameBuffer) {
    var ret = _AddListenerPreCallback(eventNameBufferPtr, callback);
    pool.Return(eventNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, ulong> _AddListenerPostCallback;
  /// <summary>
  /// the callback should receive the following: uint64 hash, IntPtr gameEvent, bool* dontBroadcast, return bool (true -> ignored, false -> supercede)
  /// </summary>
  public unsafe static ulong AddListenerPostCallback(string eventName, void* callback) {
    var pool = ArrayPool<byte>.Shared;
    var eventNameLength = Encoding.UTF8.GetByteCount(eventName);
    var eventNameBuffer = pool.Rent(eventNameLength + 1);
    Encoding.UTF8.GetBytes(eventName, eventNameBuffer);
    eventNameBuffer[eventNameLength] = 0;
    fixed (byte* eventNameBufferPtr = eventNameBuffer) {
    var ret = _AddListenerPostCallback(eventNameBufferPtr, callback);
    pool.Return(eventNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<ulong, void> _RemoveListenerPreCallback;
  public unsafe static void RemoveListenerPreCallback(ulong listenerID) {
    _RemoveListenerPreCallback(listenerID);
  }
  private unsafe static delegate* unmanaged<ulong, void> _RemoveListenerPostCallback;
  public unsafe static void RemoveListenerPostCallback(ulong listenerID) {
    _RemoveListenerPostCallback(listenerID);
  }
  private unsafe static delegate* unmanaged<byte*, void*> _CreateEvent;
  public unsafe static void* CreateEvent(string eventName) {
    var pool = ArrayPool<byte>.Shared;
    var eventNameLength = Encoding.UTF8.GetByteCount(eventName);
    var eventNameBuffer = pool.Rent(eventNameLength + 1);
    Encoding.UTF8.GetBytes(eventName, eventNameBuffer);
    eventNameBuffer[eventNameLength] = 0;
    fixed (byte* eventNameBufferPtr = eventNameBuffer) {
    var ret = _CreateEvent(eventNameBufferPtr);
    pool.Return(eventNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, void> _FreeEvent;
  public unsafe static void FreeEvent(void* event) {
    _FreeEvent(event);
  }
  private unsafe static delegate* unmanaged<void*, bool, void> _FireEvent;
  public unsafe static void FireEvent(void* event, bool dontBroadcast) {
    _FireEvent(event, dontBroadcast);
  }
  private unsafe static delegate* unmanaged<void*, int, void> _FireEventToClient;
  public unsafe static void FireEventToClient(void* event, int playerid) {
    _FireEventToClient(event, playerid);
  }
  private unsafe static delegate* unmanaged<int, byte*, bool> _IsPlayerListeningToEventName;
  public unsafe static bool IsPlayerListeningToEventName(int playerid, string eventName) {
    var pool = ArrayPool<byte>.Shared;
    var eventNameLength = Encoding.UTF8.GetByteCount(eventName);
    var eventNameBuffer = pool.Rent(eventNameLength + 1);
    Encoding.UTF8.GetBytes(eventName, eventNameBuffer);
    eventNameBuffer[eventNameLength] = 0;
    fixed (byte* eventNameBufferPtr = eventNameBuffer) {
    var ret = _IsPlayerListeningToEventName(playerid, eventNameBufferPtr);
    pool.Return(eventNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<int, void*, bool> _IsPlayerListeningToEvent;
  public unsafe static bool IsPlayerListeningToEvent(int playerid, void* event) {
    var ret = _IsPlayerListeningToEvent(playerid, event);
    return ret;
  }
}
