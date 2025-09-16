#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeAllocator {
  private unsafe static delegate* unmanaged<ulong, void*> _Alloc;
  public unsafe static void* Alloc(ulong size) {
    var ret = _Alloc(size);
    return ret;
  }
  private unsafe static delegate* unmanaged<ulong, byte*, byte*, void*> _TrackedAlloc;
  public unsafe static void* TrackedAlloc(ulong size, string identifier, string details) {
    var pool = ArrayPool<byte>.Shared;
    var identifierLength = Encoding.UTF8.GetByteCount(identifier);
    var identifierBuffer = pool.Rent(identifierLength + 1);
    Encoding.UTF8.GetBytes(identifier, identifierBuffer);
    identifierBuffer[identifierLength] = 0;
    fixed (byte* identifierBufferPtr = identifierBuffer) {

    var detailsLength = Encoding.UTF8.GetByteCount(details);
    var detailsBuffer = pool.Rent(detailsLength + 1);
    Encoding.UTF8.GetBytes(details, detailsBuffer);
    detailsBuffer[detailsLength] = 0;
    fixed (byte* detailsBufferPtr = detailsBuffer) {
    var ret = _TrackedAlloc(size, identifierBufferPtr, detailsBufferPtr);
    pool.Return(identifierBuffer);

    pool.Return(detailsBuffer);

    return ret;
  }
  }
  }
  private unsafe static delegate* unmanaged<void*, void> _Free;
  public unsafe static void Free(void* pointer) {
    _Free(pointer);
  }
  private unsafe static delegate* unmanaged<void*, ulong, void*> _Resize;
  public unsafe static void* Resize(void* pointer, ulong new_size) {
    var ret = _Resize(pointer, new_size);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, ulong> _GetSize;
  /// <summary>
  /// works only for pointers allocated through Memory.Allocator
  /// </summary>
  public unsafe static ulong GetSize(void* pointer) {
    var ret = _GetSize(pointer);
    return ret;
  }
  private unsafe static delegate* unmanaged<ulong> _GetTotalAllocated;
  public unsafe static ulong GetTotalAllocated() {
    var ret = _GetTotalAllocated();
    return ret;
  }
  private unsafe static delegate* unmanaged<byte*, ulong> _GetAllocatedByTrackedIdentifier;
  public unsafe static ulong GetAllocatedByTrackedIdentifier(string identifier) {
    var pool = ArrayPool<byte>.Shared;
    var identifierLength = Encoding.UTF8.GetByteCount(identifier);
    var identifierBuffer = pool.Rent(identifierLength + 1);
    Encoding.UTF8.GetBytes(identifier, identifierBuffer);
    identifierBuffer[identifierLength] = 0;
    fixed (byte* identifierBufferPtr = identifierBuffer) {
    var ret = _GetAllocatedByTrackedIdentifier(identifierBufferPtr);
    pool.Return(identifierBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<void*, bool> _IsPointerValid;
  public unsafe static bool IsPointerValid(void* pointer) {
    var ret = _IsPointerValid(pointer);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, void*, ulong, void> _Copy;
  public unsafe static void Copy(void* src, void* dst, ulong size) {
    _Copy(src, dst, size);
  }
}
