#pragma warning disable CS0649

using System.Buffers;
using System.Text;

namespace SwiftlyS2.Core.Natives;

internal static class NativeEntitySystem {
  private unsafe static delegate* unmanaged<void*, void*, void> _Spawn;
  public unsafe static void Spawn(void* entity, void* keyvalues) {
    _Spawn(entity, keyvalues);
  }
  private unsafe static delegate* unmanaged<void*, void> _Despawn;
  public unsafe static void Despawn(void* entity) {
    _Despawn(entity);
  }
  private unsafe static delegate* unmanaged<byte*, void*> _CreateEntityByName;
  public unsafe static void* CreateEntityByName(string name) {
    var pool = ArrayPool<byte>.Shared;
    var nameLength = Encoding.UTF8.GetByteCount(name);
    var nameBuffer = pool.Rent(nameLength + 1);
    Encoding.UTF8.GetBytes(name, nameBuffer);
    nameBuffer[nameLength] = 0;
    fixed (byte* nameBufferPtr = nameBuffer) {
    var ret = _CreateEntityByName(nameBufferPtr);
    pool.Return(nameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, int, int, void> _AcceptInputInt32;
  public unsafe static void AcceptInputInt32(void* entity, string input, void* activator, void* caller, int value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AcceptInputInt32(entity, inputBufferPtr, activator, caller, value, outputID);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, uint, int, void> _AcceptInputUInt32;
  public unsafe static void AcceptInputUInt32(void* entity, string input, void* activator, void* caller, uint value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AcceptInputUInt32(entity, inputBufferPtr, activator, caller, value, outputID);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, long, int, void> _AcceptInputInt64;
  public unsafe static void AcceptInputInt64(void* entity, string input, void* activator, void* caller, long value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AcceptInputInt64(entity, inputBufferPtr, activator, caller, value, outputID);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, ulong, int, void> _AcceptInputUInt64;
  public unsafe static void AcceptInputUInt64(void* entity, string input, void* activator, void* caller, ulong value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AcceptInputUInt64(entity, inputBufferPtr, activator, caller, value, outputID);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, float, int, void> _AcceptInputFloat;
  public unsafe static void AcceptInputFloat(void* entity, string input, void* activator, void* caller, float value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AcceptInputFloat(entity, inputBufferPtr, activator, caller, value, outputID);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, double, int, void> _AcceptInputDouble;
  public unsafe static void AcceptInputDouble(void* entity, string input, void* activator, void* caller, double value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AcceptInputDouble(entity, inputBufferPtr, activator, caller, value, outputID);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, bool, int, void> _AcceptInputBool;
  public unsafe static void AcceptInputBool(void* entity, string input, void* activator, void* caller, bool value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AcceptInputBool(entity, inputBufferPtr, activator, caller, value, outputID);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, byte*, int, void> _AcceptInputString;
  public unsafe static void AcceptInputString(void* entity, string input, void* activator, void* caller, string value, int outputID) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {

    var valueLength = Encoding.UTF8.GetByteCount(value);
    var valueBuffer = pool.Rent(valueLength + 1);
    Encoding.UTF8.GetBytes(value, valueBuffer);
    valueBuffer[valueLength] = 0;
    fixed (byte* valueBufferPtr = valueBuffer) {
    _AcceptInputString(entity, inputBufferPtr, activator, caller, valueBufferPtr, outputID);
    pool.Return(inputBuffer);

    pool.Return(valueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, int, float, void> _AddEntityIOEventInt32;
  public unsafe static void AddEntityIOEventInt32(void* entity, string input, void* activator, void* caller, int value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AddEntityIOEventInt32(entity, inputBufferPtr, activator, caller, value, delay);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, uint, float, void> _AddEntityIOEventUInt32;
  public unsafe static void AddEntityIOEventUInt32(void* entity, string input, void* activator, void* caller, uint value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AddEntityIOEventUInt32(entity, inputBufferPtr, activator, caller, value, delay);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, long, float, void> _AddEntityIOEventInt64;
  public unsafe static void AddEntityIOEventInt64(void* entity, string input, void* activator, void* caller, long value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AddEntityIOEventInt64(entity, inputBufferPtr, activator, caller, value, delay);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, ulong, float, void> _AddEntityIOEventUInt64;
  public unsafe static void AddEntityIOEventUInt64(void* entity, string input, void* activator, void* caller, ulong value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AddEntityIOEventUInt64(entity, inputBufferPtr, activator, caller, value, delay);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, float, float, void> _AddEntityIOEventFloat;
  public unsafe static void AddEntityIOEventFloat(void* entity, string input, void* activator, void* caller, float value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AddEntityIOEventFloat(entity, inputBufferPtr, activator, caller, value, delay);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, double, float, void> _AddEntityIOEventDouble;
  public unsafe static void AddEntityIOEventDouble(void* entity, string input, void* activator, void* caller, double value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AddEntityIOEventDouble(entity, inputBufferPtr, activator, caller, value, delay);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, bool, float, void> _AddEntityIOEventBool;
  public unsafe static void AddEntityIOEventBool(void* entity, string input, void* activator, void* caller, bool value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {
    _AddEntityIOEventBool(entity, inputBufferPtr, activator, caller, value, delay);
    pool.Return(inputBuffer);

  }
  }
  private unsafe static delegate* unmanaged<void*, byte*, void*, void*, byte*, float, void> _AddEntityIOEventString;
  public unsafe static void AddEntityIOEventString(void* entity, string input, void* activator, void* caller, string value, float delay) {
    var pool = ArrayPool<byte>.Shared;
    var inputLength = Encoding.UTF8.GetByteCount(input);
    var inputBuffer = pool.Rent(inputLength + 1);
    Encoding.UTF8.GetBytes(input, inputBuffer);
    inputBuffer[inputLength] = 0;
    fixed (byte* inputBufferPtr = inputBuffer) {

    var valueLength = Encoding.UTF8.GetByteCount(value);
    var valueBuffer = pool.Rent(valueLength + 1);
    Encoding.UTF8.GetBytes(value, valueBuffer);
    valueBuffer[valueLength] = 0;
    fixed (byte* valueBufferPtr = valueBuffer) {
    _AddEntityIOEventString(entity, inputBufferPtr, activator, caller, valueBufferPtr, delay);
    pool.Return(inputBuffer);

    pool.Return(valueBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<void*, bool> _IsValidEntity;
  public unsafe static bool IsValidEntity(void* entity) {
    var ret = _IsValidEntity(entity);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*> _GetGameRules;
  public unsafe static void* GetGameRules() {
    var ret = _GetGameRules();
    return ret;
  }
  private unsafe static delegate* unmanaged<void*> _GetEntitySystem;
  public unsafe static void* GetEntitySystem() {
    var ret = _GetEntitySystem();
    return ret;
  }
}
