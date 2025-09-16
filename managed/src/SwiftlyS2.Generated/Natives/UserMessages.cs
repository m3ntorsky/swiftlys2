#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeUserMessages {
  private unsafe static delegate* unmanaged<int, void*> _AllocateNetMessageByID;
  public unsafe static void* AllocateNetMessageByID(int msgid) {
    var ret = _AllocateNetMessageByID(msgid);
    return ret;
  }
  private unsafe static delegate* unmanaged<byte*, void*> _AllocateNetMessageByPartialName;
  public unsafe static void* AllocateNetMessageByPartialName(string name) {
    var pool = ArrayPool<byte>.Shared;
    var nameLength = Encoding.UTF8.GetByteCount(name);
    var nameBuffer = pool.Rent(nameLength + 1);
    Encoding.UTF8.GetBytes(name, nameBuffer);
    nameBuffer[nameLength] = 0;
    fixed (byte* nameBufferPtr = nameBuffer) {
    var ret = _AllocateNetMessageByPartialName(nameBufferPtr);
    pool.Return(nameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, void> _DeallocateNetMessage;
  public unsafe static void DeallocateNetMessage(void* netmsg) {
    _DeallocateNetMessage(netmsg);
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool> _HasField;
  public unsafe static bool HasField(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _HasField(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int> _GetInt32;
  public unsafe static int GetInt32(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetInt32(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, int> _GetRepeatedInt32;
  public unsafe static int GetRepeatedInt32(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedInt32(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, void> _SetInt32;
  public unsafe static void SetInt32(void* netmsg, string fieldName, int value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetInt32(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, int, void> _SetRepeatedInt32;
  public unsafe static void SetRepeatedInt32(void* netmsg, string fieldName, int index, int value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedInt32(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, void> _AddInt32;
  public unsafe static void AddInt32(void* netmsg, string fieldName, int value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddInt32(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, long> _GetInt64;
  public unsafe static long GetInt64(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetInt64(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, long> _GetRepeatedInt64;
  public unsafe static long GetRepeatedInt64(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedInt64(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, long, void> _SetInt64;
  public unsafe static void SetInt64(void* netmsg, string fieldName, long value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetInt64(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, long, void> _SetRepeatedInt64;
  public unsafe static void SetRepeatedInt64(void* netmsg, string fieldName, int index, long value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedInt64(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, long, void> _AddInt64;
  public unsafe static void AddInt64(void* netmsg, string fieldName, long value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddInt64(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, uint> _GetUInt32;
  public unsafe static uint GetUInt32(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetUInt32(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, uint> _GetRepeatedUInt32;
  public unsafe static uint GetRepeatedUInt32(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedUInt32(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, uint, void> _SetUInt32;
  public unsafe static void SetUInt32(void* netmsg, string fieldName, uint value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetUInt32(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, uint, void> _SetRepeatedUInt32;
  public unsafe static void SetRepeatedUInt32(void* netmsg, string fieldName, int index, uint value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedUInt32(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, uint, void> _AddUInt32;
  public unsafe static void AddUInt32(void* netmsg, string fieldName, uint value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddUInt32(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, ulong> _GetUInt64;
  public unsafe static ulong GetUInt64(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetUInt64(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, ulong> _GetRepeatedUInt64;
  public unsafe static ulong GetRepeatedUInt64(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedUInt64(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, ulong, void> _SetUInt64;
  public unsafe static void SetUInt64(void* netmsg, string fieldName, ulong value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetUInt64(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, ulong, void> _SetRepeatedUInt64;
  public unsafe static void SetRepeatedUInt64(void* netmsg, string fieldName, int index, ulong value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedUInt64(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, ulong, void> _AddUInt64;
  public unsafe static void AddUInt64(void* netmsg, string fieldName, ulong value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddUInt64(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool> _GetBool;
  public unsafe static bool GetBool(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetBool(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, bool> _GetRepeatedBool;
  public unsafe static bool GetRepeatedBool(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedBool(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool, void> _SetBool;
  public unsafe static void SetBool(void* netmsg, string fieldName, bool value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetBool(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, bool, void> _SetRepeatedBool;
  public unsafe static void SetRepeatedBool(void* netmsg, string fieldName, int index, bool value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedBool(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, bool, void> _AddBool;
  public unsafe static void AddBool(void* netmsg, string fieldName, bool value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddBool(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, float> _GetFloat;
  public unsafe static float GetFloat(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetFloat(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, float> _GetRepeatedFloat;
  public unsafe static float GetRepeatedFloat(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedFloat(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, float, void> _SetFloat;
  public unsafe static void SetFloat(void* netmsg, string fieldName, float value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetFloat(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, float, void> _SetRepeatedFloat;
  public unsafe static void SetRepeatedFloat(void* netmsg, string fieldName, int index, float value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedFloat(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, float, void> _AddFloat;
  public unsafe static void AddFloat(void* netmsg, string fieldName, float value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddFloat(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, double> _GetDouble;
  public unsafe static double GetDouble(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetDouble(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, double> _GetRepeatedDouble;
  public unsafe static double GetRepeatedDouble(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedDouble(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, double, void> _SetDouble;
  public unsafe static void SetDouble(void* netmsg, string fieldName, double value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetDouble(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, double, void> _SetRepeatedDouble;
  public unsafe static void SetRepeatedDouble(void* netmsg, string fieldName, int index, double value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedDouble(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, double, void> _AddDouble;
  public unsafe static void AddDouble(void* netmsg, string fieldName, double value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddDouble(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, byte*, int> _GetString;
  public unsafe static string GetString(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetString(null, netmsg, fieldNameBufferPtr);

    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetString(retBufferPtr, netmsg, fieldNameBufferPtr);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    pool.Return(fieldNameBuffer);

    return retString;
  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, byte*, int, int> _GetRepeatedString;
  public unsafe static string GetRepeatedString(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedString(null, netmsg, fieldNameBufferPtr, index);

    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetRepeatedString(retBufferPtr, netmsg, fieldNameBufferPtr, index);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    pool.Return(fieldNameBuffer);

    return retString;
  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, byte*, void> _SetString;
  public unsafe static void SetString(void* netmsg, string fieldName, string value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {

    var valueLength = Encoding.UTF8.GetByteCount(value);
    var valueBuffer = pool.Rent(valueLength + 1);
    Encoding.UTF8.GetBytes(value, valueBuffer);
    valueBuffer[valueLength] = 0;
    fixed (byte* valueBufferPtr = valueBuffer) {
    _SetString(netmsg, fieldNameBufferPtr, valueBufferPtr);
    pool.Return(fieldNameBuffer);

    pool.Return(valueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, byte*, void> _SetRepeatedString;
  public unsafe static void SetRepeatedString(void* netmsg, string fieldName, int index, string value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {

    var valueLength = Encoding.UTF8.GetByteCount(value);
    var valueBuffer = pool.Rent(valueLength + 1);
    Encoding.UTF8.GetBytes(value, valueBuffer);
    valueBuffer[valueLength] = 0;
    fixed (byte* valueBufferPtr = valueBuffer) {
    _SetRepeatedString(netmsg, fieldNameBufferPtr, index, valueBufferPtr);
    pool.Return(fieldNameBuffer);

    pool.Return(valueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, byte*, void> _AddString;
  public unsafe static void AddString(void* netmsg, string fieldName, string value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {

    var valueLength = Encoding.UTF8.GetByteCount(value);
    var valueBuffer = pool.Rent(valueLength + 1);
    Encoding.UTF8.GetBytes(value, valueBuffer);
    valueBuffer[valueLength] = 0;
    fixed (byte* valueBufferPtr = valueBuffer) {
    _AddString(netmsg, fieldNameBufferPtr, valueBufferPtr);
    pool.Return(fieldNameBuffer);

    pool.Return(valueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Vector2D> _GetVector2D;
  public unsafe static Vector2D GetVector2D(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetVector2D(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, Vector2D> _GetRepeatedVector2D;
  public unsafe static Vector2D GetRepeatedVector2D(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedVector2D(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Vector2D, void> _SetVector2D;
  public unsafe static void SetVector2D(void* netmsg, string fieldName, Vector2D value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetVector2D(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, Vector2D, void> _SetRepeatedVector2D;
  public unsafe static void SetRepeatedVector2D(void* netmsg, string fieldName, int index, Vector2D value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedVector2D(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Vector2D, void> _AddVector2D;
  public unsafe static void AddVector2D(void* netmsg, string fieldName, Vector2D value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddVector2D(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Vector> _GetVector;
  public unsafe static Vector GetVector(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetVector(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, Vector> _GetRepeatedVector;
  public unsafe static Vector GetRepeatedVector(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedVector(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Vector, void> _SetVector;
  public unsafe static void SetVector(void* netmsg, string fieldName, Vector value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetVector(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, Vector, void> _SetRepeatedVector;
  public unsafe static void SetRepeatedVector(void* netmsg, string fieldName, int index, Vector value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedVector(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Vector, void> _AddVector;
  public unsafe static void AddVector(void* netmsg, string fieldName, Vector value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddVector(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Color> _GetColor;
  public unsafe static Color GetColor(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetColor(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, Color> _GetRepeatedColor;
  public unsafe static Color GetRepeatedColor(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedColor(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Color, void> _SetColor;
  public unsafe static void SetColor(void* netmsg, string fieldName, Color value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetColor(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, Color, void> _SetRepeatedColor;
  public unsafe static void SetRepeatedColor(void* netmsg, string fieldName, int index, Color value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedColor(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, Color, void> _AddColor;
  public unsafe static void AddColor(void* netmsg, string fieldName, Color value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddColor(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, QAngle> _GetQAngle;
  public unsafe static QAngle GetQAngle(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetQAngle(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, QAngle> _GetRepeatedQAngle;
  public unsafe static QAngle GetRepeatedQAngle(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedQAngle(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, QAngle, void> _SetQAngle;
  public unsafe static void SetQAngle(void* netmsg, string fieldName, QAngle value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetQAngle(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, QAngle, void> _SetRepeatedQAngle;
  public unsafe static void SetRepeatedQAngle(void* netmsg, string fieldName, int index, QAngle value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _SetRepeatedQAngle(netmsg, fieldNameBufferPtr, index, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, QAngle, void> _AddQAngle;
  public unsafe static void AddQAngle(void* netmsg, string fieldName, QAngle value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    _AddQAngle(netmsg, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, byte*, int> _GetBytes;
  public unsafe static byte[] GetBytes(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetBytes(null, netmsg, fieldNameBufferPtr);

    var retBuffer = pool.Rent(ret);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetBytes(retBufferPtr, netmsg, fieldNameBufferPtr);
    var retBytes = new byte[ret];
    for(int i = 0; i < ret; i++) retBytes[i] = retBufferPtr[i];
    pool.Return(retBuffer);

    pool.Return(fieldNameBuffer);

    return retBytes;
  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, void*, byte*, int, int> _GetRepeatedBytes;
  public unsafe static byte[] GetRepeatedBytes(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedBytes(null, netmsg, fieldNameBufferPtr, index);

    var retBuffer = pool.Rent(ret);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetRepeatedBytes(retBufferPtr, netmsg, fieldNameBufferPtr, index);
    var retBytes = new byte[ret];
    for(int i = 0; i < ret; i++) retBytes[i] = retBufferPtr[i];
    pool.Return(retBuffer);

    pool.Return(fieldNameBuffer);

    return retBytes;
  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, byte*, void> _SetBytes;
  public unsafe static void SetBytes(void* netmsg, string fieldName, byte[] value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {

    fixed (byte* valueBufferPtr = value) {
    _SetBytes(netmsg, fieldNameBufferPtr, valueBufferPtr);
    pool.Return(fieldNameBuffer);

      }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, byte*, void> _SetRepeatedBytes;
  public unsafe static void SetRepeatedBytes(void* netmsg, string fieldName, int index, byte[] value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {

    fixed (byte* valueBufferPtr = value) {
    _SetRepeatedBytes(netmsg, fieldNameBufferPtr, index, valueBufferPtr);
    pool.Return(fieldNameBuffer);

      }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, byte*, void> _AddBytes;
  public unsafe static void AddBytes(void* netmsg, string fieldName, byte[] value) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {

    fixed (byte* valueBufferPtr = value) {
    _AddBytes(netmsg, fieldNameBufferPtr, valueBufferPtr);
    pool.Return(fieldNameBuffer);

      }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _GetNestedMessage;
  public unsafe static void* GetNestedMessage(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetNestedMessage(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, int, void*> _GetRepeatedNestedMessage;
  public unsafe static void* GetRepeatedNestedMessage(void* netmsg, string fieldName, int index) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _GetRepeatedNestedMessage(netmsg, fieldNameBufferPtr, index);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*> _AddNestedMessage;
  public unsafe static void* AddNestedMessage(void* netmsg, string fieldName) {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
    var ret = _AddNestedMessage(netmsg, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, int, int, void> _SendMessage;
  public unsafe static void SendMessage(void* netmsg, int msgid, int playerid) {
    _SendMessage(netmsg, msgid, playerid);
  }
  private unsafe static delegate* unmanaged<void*, int, ulong, void> _SendMessageToPlayers;
  /// <summary>
  /// each bit in player_mask represents a playerid
  /// </summary>
  public unsafe static void SendMessageToPlayers(void* netmsg, int msgid, ulong playermask) {
    _SendMessageToPlayers(netmsg, msgid, playermask);
  }
}
