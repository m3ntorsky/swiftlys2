using System.Buffers;
using System.Text;

namespace SwiftlyS2.Natives;

public static class NativeSchema {
  private unsafe static delegate* unmanaged<void*, ulong, void> _SetStateChanged;
  public unsafe static void SetStateChanged(void* entity, ulong hash) {
    _SetStateChanged(entity, hash);
  }
  private unsafe static delegate* unmanaged<byte*, uint> _FindChainOffset;
  public unsafe static uint FindChainOffset(string className) {
    var pool = ArrayPool<byte>.Shared;
    var classNameLength = Encoding.UTF8.GetByteCount(className);
    var classNameBuffer = pool.Rent(classNameLength + 1);
    Encoding.UTF8.GetBytes(className, classNameBuffer);
    classNameBuffer[classNameLength] = 0;
    fixed (byte* classNameBufferPtr = classNameBuffer) {
    var ret = _FindChainOffset(classNameBufferPtr);
    pool.Return(classNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<ulong, int> _GetOffset;
  public unsafe static int GetOffset(ulong hash) {
    var ret = _GetOffset(hash);
    return ret;
  }
  private unsafe static delegate* unmanaged<byte*, bool> _IsStruct;
  public unsafe static bool IsStruct(string className) {
    var pool = ArrayPool<byte>.Shared;
    var classNameLength = Encoding.UTF8.GetByteCount(className);
    var classNameBuffer = pool.Rent(classNameLength + 1);
    Encoding.UTF8.GetBytes(className, classNameBuffer);
    classNameBuffer[classNameLength] = 0;
    fixed (byte* classNameBufferPtr = classNameBuffer) {
    var ret = _IsStruct(classNameBufferPtr);
    pool.Return(classNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _IsClassLoaded;
  public unsafe static bool IsClassLoaded(string className) {
    var pool = ArrayPool<byte>.Shared;
    var classNameLength = Encoding.UTF8.GetByteCount(className);
    var classNameBuffer = pool.Rent(classNameLength + 1);
    Encoding.UTF8.GetBytes(className, classNameBuffer);
    classNameBuffer[classNameLength] = 0;
    fixed (byte* classNameBufferPtr = classNameBuffer) {
    var ret = _IsClassLoaded(classNameBufferPtr);
    pool.Return(classNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, ulong, void*> _GetPropPtr;
  public unsafe static void* GetPropPtr(void* entity, ulong hash) {
    var ret = _GetPropPtr(entity, hash);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, ulong, void*, uint, void> _WritePropPtr;
  public unsafe static void WritePropPtr(void* entity, ulong hash, void* value, uint size) {
    _WritePropPtr(entity, hash, value, size);
  }
  private unsafe static delegate* unmanaged<void*, void*> _GetVData;
  public unsafe static void* GetVData(void* entity) {
    var ret = _GetVData(entity);
    return ret;
  }
}
