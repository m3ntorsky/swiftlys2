#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeConvars {
  private unsafe static delegate* unmanaged<int, byte*, void> _QueryClientConvar;
  public unsafe static void QueryClientConvar(int playerid, string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _QueryClientConvar(playerid, cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<nint, int> _AddQueryClientCvarCallback;
  /// <summary>
  /// the callback should receive the following: int32 playerid, string cvarName, string cvarValue
  /// </summary>
  public unsafe static int AddQueryClientCvarCallback(nint callback) {
    var ret = _AddQueryClientCvarCallback(callback);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, void> _RemoveQueryClientCvarCallback;
  public unsafe static void RemoveQueryClientCvarCallback(int callbackID) {
    _RemoveQueryClientCvarCallback(callbackID);
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, short, void> _CreateConvarInt16;
  public unsafe static void CreateConvarInt16(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, short defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarInt16(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, ushort, void> _CreateConvarUInt16;
  public unsafe static void CreateConvarUInt16(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, ushort defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarUInt16(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, int, void> _CreateConvarInt32;
  public unsafe static void CreateConvarInt32(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, int defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarInt32(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, uint, void> _CreateConvarUInt32;
  public unsafe static void CreateConvarUInt32(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, uint defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarUInt32(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, long, void> _CreateConvarInt64;
  public unsafe static void CreateConvarInt64(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, long defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarInt64(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, ulong, void> _CreateConvarUInt64;
  public unsafe static void CreateConvarUInt64(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, ulong defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarUInt64(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, bool, void> _CreateConvarBool;
  public unsafe static void CreateConvarBool(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, bool defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarBool(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, float, void> _CreateConvarFloat;
  public unsafe static void CreateConvarFloat(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, float defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarFloat(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, double, void> _CreateConvarDouble;
  public unsafe static void CreateConvarDouble(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, double defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarDouble(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, Color, void> _CreateConvarColor;
  public unsafe static void CreateConvarColor(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, Color defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarColor(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, Vector2D, void> _CreateConvarVector2D;
  public unsafe static void CreateConvarVector2D(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, Vector2D defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarVector2D(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, Vector, void> _CreateConvarVector;
  public unsafe static void CreateConvarVector(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, Vector defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarVector(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, Vector4D, void> _CreateConvarVector4D;
  public unsafe static void CreateConvarVector4D(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, Vector4D defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarVector4D(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, QAngle, void> _CreateConvarQAngle;
  public unsafe static void CreateConvarQAngle(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, QAngle defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {
    _CreateConvarQAngle(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, ulong, byte*, byte*, void> _CreateConvarString;
  public unsafe static void CreateConvarString(string cvarName, int cvarType, ulong cvarFlags, string helpMessage, string defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var helpMessageLength = Encoding.UTF8.GetByteCount(helpMessage);
    var helpMessageBuffer = pool.Rent(helpMessageLength + 1);
    Encoding.UTF8.GetBytes(helpMessage, helpMessageBuffer);
    helpMessageBuffer[helpMessageLength] = 0;
    fixed (byte* helpMessageBufferPtr = helpMessageBuffer) {

    var defaultValueLength = Encoding.UTF8.GetByteCount(defaultValue);
    var defaultValueBuffer = pool.Rent(defaultValueLength + 1);
    Encoding.UTF8.GetBytes(defaultValue, defaultValueBuffer);
    defaultValueBuffer[defaultValueLength] = 0;
    fixed (byte* defaultValueBufferPtr = defaultValueBuffer) {
    _CreateConvarString(cvarNameBufferPtr, cvarType, cvarFlags, helpMessageBufferPtr, defaultValueBufferPtr);
    pool.Return(cvarNameBuffer);

    pool.Return(helpMessageBuffer);

    pool.Return(defaultValueBuffer);

  }
  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, void> _DeleteConvar;
  public unsafe static void DeleteConvar(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _DeleteConvar(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _ExistsConvar;
  public unsafe static bool ExistsConvar(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _ExistsConvar(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, int> _GetConvarType;
  public unsafe static int GetConvarType(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarType(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, nint> _GetConvarDataAddress;
  public unsafe static nint GetConvarDataAddress(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarDataAddress(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, short> _GetConvarValueInt16;
  public unsafe static short GetConvarValueInt16(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueInt16(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, ushort> _GetConvarValueUInt16;
  public unsafe static ushort GetConvarValueUInt16(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueUInt16(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, int> _GetConvarValueInt32;
  public unsafe static int GetConvarValueInt32(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueInt32(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, uint> _GetConvarValueUInt32;
  public unsafe static uint GetConvarValueUInt32(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueUInt32(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, long> _GetConvarValueInt64;
  public unsafe static long GetConvarValueInt64(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueInt64(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, ulong> _GetConvarValueUInt64;
  public unsafe static ulong GetConvarValueUInt64(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueUInt64(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _GetConvarValueBool;
  public unsafe static bool GetConvarValueBool(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueBool(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, float> _GetConvarValueFloat;
  public unsafe static float GetConvarValueFloat(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueFloat(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, double> _GetConvarValueDouble;
  public unsafe static double GetConvarValueDouble(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueDouble(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, Color> _GetConvarValueColor;
  public unsafe static Color GetConvarValueColor(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueColor(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, Vector2D> _GetConvarValueVector2D;
  public unsafe static Vector2D GetConvarValueVector2D(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueVector2D(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, Vector> _GetConvarValueVector;
  public unsafe static Vector GetConvarValueVector(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueVector(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, Vector4D> _GetConvarValueVector4D;
  public unsafe static Vector4D GetConvarValueVector4D(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueVector4D(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, QAngle> _GetConvarValueQAngle;
  public unsafe static QAngle GetConvarValueQAngle(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueQAngle(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, int> _GetConvarValueString;
  public unsafe static string GetConvarValueString(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetConvarValueString(null, cvarNameBufferPtr);

    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetConvarValueString(retBufferPtr, cvarNameBufferPtr);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    pool.Return(cvarNameBuffer);

    return retString;
  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, short, void> _SetConvarValueInt16;
  public unsafe static void SetConvarValueInt16(string cvarName, short defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueInt16(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, ushort, void> _SetConvarValueUInt16;
  public unsafe static void SetConvarValueUInt16(string cvarName, ushort defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueUInt16(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, int, void> _SetConvarValueInt32;
  public unsafe static void SetConvarValueInt32(string cvarName, int defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueInt32(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, uint, void> _SetConvarValueUInt32;
  public unsafe static void SetConvarValueUInt32(string cvarName, uint defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueUInt32(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, long, void> _SetConvarValueInt64;
  public unsafe static void SetConvarValueInt64(string cvarName, long defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueInt64(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, ulong, void> _SetConvarValueUInt64;
  public unsafe static void SetConvarValueUInt64(string cvarName, ulong defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueUInt64(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, bool, void> _SetConvarValueBool;
  public unsafe static void SetConvarValueBool(string cvarName, bool defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueBool(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, float, void> _SetConvarValueFloat;
  public unsafe static void SetConvarValueFloat(string cvarName, float defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueFloat(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, double, void> _SetConvarValueDouble;
  public unsafe static void SetConvarValueDouble(string cvarName, double defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueDouble(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, Color, void> _SetConvarValueColor;
  public unsafe static void SetConvarValueColor(string cvarName, Color defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueColor(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, Vector2D, void> _SetConvarValueVector2D;
  public unsafe static void SetConvarValueVector2D(string cvarName, Vector2D defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueVector2D(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, Vector, void> _SetConvarValueVector;
  public unsafe static void SetConvarValueVector(string cvarName, Vector defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueVector(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, Vector4D, void> _SetConvarValueVector4D;
  public unsafe static void SetConvarValueVector4D(string cvarName, Vector4D defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueVector4D(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, QAngle, void> _SetConvarValueQAngle;
  public unsafe static void SetConvarValueQAngle(string cvarName, QAngle defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetConvarValueQAngle(cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, void> _SetConvarValueString;
  public unsafe static void SetConvarValueString(string cvarName, string defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var defaultValueLength = Encoding.UTF8.GetByteCount(defaultValue);
    var defaultValueBuffer = pool.Rent(defaultValueLength + 1);
    Encoding.UTF8.GetBytes(defaultValue, defaultValueBuffer);
    defaultValueBuffer[defaultValueLength] = 0;
    fixed (byte* defaultValueBufferPtr = defaultValueBuffer) {
    _SetConvarValueString(cvarNameBufferPtr, defaultValueBufferPtr);
    pool.Return(cvarNameBuffer);

    pool.Return(defaultValueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<int, byte*, short, void> _SetClientConvarValueInt16;
  public unsafe static void SetClientConvarValueInt16(int playerid, string cvarName, short defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueInt16(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, ushort, void> _SetClientConvarValueUInt16;
  public unsafe static void SetClientConvarValueUInt16(int playerid, string cvarName, ushort defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueUInt16(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, int, void> _SetClientConvarValueInt32;
  public unsafe static void SetClientConvarValueInt32(int playerid, string cvarName, int defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueInt32(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, uint, void> _SetClientConvarValueUInt32;
  public unsafe static void SetClientConvarValueUInt32(int playerid, string cvarName, uint defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueUInt32(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, long, void> _SetClientConvarValueInt64;
  public unsafe static void SetClientConvarValueInt64(int playerid, string cvarName, long defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueInt64(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, ulong, void> _SetClientConvarValueUInt64;
  public unsafe static void SetClientConvarValueUInt64(int playerid, string cvarName, ulong defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueUInt64(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, bool, void> _SetClientConvarValueBool;
  public unsafe static void SetClientConvarValueBool(int playerid, string cvarName, bool defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueBool(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, float, void> _SetClientConvarValueFloat;
  public unsafe static void SetClientConvarValueFloat(int playerid, string cvarName, float defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueFloat(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, double, void> _SetClientConvarValueDouble;
  public unsafe static void SetClientConvarValueDouble(int playerid, string cvarName, double defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueDouble(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, Color, void> _SetClientConvarValueColor;
  public unsafe static void SetClientConvarValueColor(int playerid, string cvarName, Color defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueColor(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, Vector2D, void> _SetClientConvarValueVector2D;
  public unsafe static void SetClientConvarValueVector2D(int playerid, string cvarName, Vector2D defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueVector2D(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, Vector, void> _SetClientConvarValueVector;
  public unsafe static void SetClientConvarValueVector(int playerid, string cvarName, Vector defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueVector(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, Vector4D, void> _SetClientConvarValueVector4D;
  public unsafe static void SetClientConvarValueVector4D(int playerid, string cvarName, Vector4D defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueVector4D(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, QAngle, void> _SetClientConvarValueQAngle;
  public unsafe static void SetClientConvarValueQAngle(int playerid, string cvarName, QAngle defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _SetClientConvarValueQAngle(playerid, cvarNameBufferPtr, defaultValue);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, byte*, byte*, void> _SetClientConvarValueString;
  public unsafe static void SetClientConvarValueString(int playerid, string cvarName, string defaultValue) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {

    var defaultValueLength = Encoding.UTF8.GetByteCount(defaultValue);
    var defaultValueBuffer = pool.Rent(defaultValueLength + 1);
    Encoding.UTF8.GetBytes(defaultValue, defaultValueBuffer);
    defaultValueBuffer[defaultValueLength] = 0;
    fixed (byte* defaultValueBufferPtr = defaultValueBuffer) {
    _SetClientConvarValueString(playerid, cvarNameBufferPtr, defaultValueBufferPtr);
    pool.Return(cvarNameBuffer);

    pool.Return(defaultValueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, ulong, void> _AddFlags;
  public unsafe static void AddFlags(string cvarName, ulong flags) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _AddFlags(cvarNameBufferPtr, flags);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, ulong, void> _RemoveFlags;
  public unsafe static void RemoveFlags(string cvarName, ulong flags) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _RemoveFlags(cvarNameBufferPtr, flags);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, void> _ClearFlags;
  public unsafe static void ClearFlags(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    _ClearFlags(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, ulong> _GetFlags;
  public unsafe static ulong GetFlags(string cvarName) {
    var pool = ArrayPool<byte>.Shared;
    var cvarNameLength = Encoding.UTF8.GetByteCount(cvarName);
    var cvarNameBuffer = pool.Rent(cvarNameLength + 1);
    Encoding.UTF8.GetBytes(cvarName, cvarNameBuffer);
    cvarNameBuffer[cvarNameLength] = 0;
    fixed (byte* cvarNameBufferPtr = cvarNameBuffer) {
    var ret = _GetFlags(cvarNameBufferPtr);
    pool.Return(cvarNameBuffer);

    return ret;
  }
  }
}
