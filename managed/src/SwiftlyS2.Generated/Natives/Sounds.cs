#pragma warning disable CS0649

using System.Buffers;
using System.Text;

namespace SwiftlyS2.Core.Natives;

internal static class NativeSounds {
  private unsafe static delegate* unmanaged<void*> _CreateSoundEvent;
  public unsafe static void* CreateSoundEvent() {
    var ret = _CreateSoundEvent();
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, void> _DestroySoundEvent;
  public unsafe static void DestroySoundEvent(void* soundEvent) {
    _DestroySoundEvent(soundEvent);
  }
  private unsafe static delegate* unmanaged<void*, uint> _Emit;
  public unsafe static uint Emit(void* soundEvent) {
    var ret = _Emit(soundEvent);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, byte*, void> _SetName;
  public unsafe static void SetName(void* soundEvent, string name) {
    var pool = ArrayPool<byte>.Shared;
    var nameLength = Encoding.UTF8.GetByteCount(name);
    var nameBuffer = pool.Rent(nameLength + 1);
    Encoding.UTF8.GetBytes(name, nameBuffer);
    nameBuffer[nameLength] = 0;
    fixed (byte* nameBufferPtr = nameBuffer) {
    _SetName(soundEvent, nameBufferPtr);
    pool.Return(nameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, int> _GetName;
  public unsafe static string GetName(void* soundEvent) {
    var ret = _GetName(null, soundEvent);
    var pool = ArrayPool<byte>.Shared;
    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetName(retBufferPtr, soundEvent);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    return retString;
  }
  }
  private unsafe static delegate* unmanaged<void*, int, void> _SetSourceEntityIndex;
  public unsafe static void SetSourceEntityIndex(void* soundEvent, int index) {
    _SetSourceEntityIndex(soundEvent, index);
  }
  private unsafe static delegate* unmanaged<void*, int> _GetSourceEntityIndex;
  public unsafe static int GetSourceEntityIndex(void* soundEvent) {
    var ret = _GetSourceEntityIndex(soundEvent);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, int, void> _AddClient;
  public unsafe static void AddClient(void* soundEvent, int playerid) {
    _AddClient(soundEvent, playerid);
  }
  private unsafe static delegate* unmanaged<void*, int, void> _RemoveClient;
  public unsafe static void RemoveClient(void* soundEvent, int playerid) {
    _RemoveClient(soundEvent, playerid);
  }
  private unsafe static delegate* unmanaged<void*, void> _ClearClients;
  public unsafe static void ClearClients(void* soundEvent) {
    _ClearClients(soundEvent);
  }
  private unsafe static delegate* unmanaged<void*, void> _AddAllClients;
  public unsafe static void AddAllClients(void* soundEvent) {
    _AddAllClients(soundEvent);
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool> _HasField;
  public unsafe static bool HasField(void* soundEvent, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _HasField(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool, void> _SetBool;
  public unsafe static void SetBool(void* soundEvent, string fieldName, bool value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetBool(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool> _GetBool;
  public unsafe static bool GetBool(void* soundEvent, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetBool(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, void> _SetInt32;
  public unsafe static void SetInt32(void* soundEvent, string fieldName, int value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetInt32(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int> _GetInt32;
  public unsafe static int GetInt32(void* soundEvent, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetInt32(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, uint, void> _SetUInt32;
  public unsafe static void SetUInt32(void* soundEvent, string fieldName, uint value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetUInt32(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, uint> _GetUInt32;
  public unsafe static uint GetUInt32(void* soundEvent, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetUInt32(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, ulong, void> _SetUInt64;
  public unsafe static void SetUInt64(void* soundEvent, string fieldName, ulong value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetUInt64(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, ulong> _GetUInt64;
  public unsafe static ulong GetUInt64(void* soundEvent, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetUInt64(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, float, void> _SetFloat;
  public unsafe static void SetFloat(void* soundEvent, string fieldName, float value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetFloat(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, float> _GetFloat;
  public unsafe static float GetFloat(void* soundEvent, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetFloat(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
}
