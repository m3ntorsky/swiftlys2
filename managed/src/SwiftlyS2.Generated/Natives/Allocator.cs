#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeAllocator {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<ulong, nint> _Alloc;
  public unsafe static nint Alloc(ulong size) {
    try {
    var ret = _Alloc(size);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<ulong, byte*, byte*, nint> _TrackedAlloc;
  public unsafe static nint TrackedAlloc(ulong size, string identifier, string details) {
    try {
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
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _Free;
  public unsafe static void Free(nint pointer) {
    try {
    _Free(pointer);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, ulong, nint> _Resize;
  public unsafe static nint Resize(nint pointer, ulong new_size) {
    try {
    var ret = _Resize(pointer, new_size);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, ulong> _GetSize;
  /// <summary>
  /// works only for pointers allocated through Memory.Allocator
  /// </summary>
  public unsafe static ulong GetSize(nint pointer) {
    try {
    var ret = _GetSize(pointer);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<ulong> _GetTotalAllocated;
  public unsafe static ulong GetTotalAllocated() {
    try {
    var ret = _GetTotalAllocated();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, ulong> _GetAllocatedByTrackedIdentifier;
  public unsafe static ulong GetAllocatedByTrackedIdentifier(string identifier) {
    try {
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
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, bool> _IsPointerValid;
  public unsafe static bool IsPointerValid(nint pointer) {
    try {
    var ret = _IsPointerValid(pointer);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, nint, ulong, void> _Copy;
  public unsafe static void Copy(nint src, nint dst, ulong size) {
    try {
    _Copy(src, dst, size);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
