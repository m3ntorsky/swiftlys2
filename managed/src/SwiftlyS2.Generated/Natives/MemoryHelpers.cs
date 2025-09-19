#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeMemoryHelpers {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<byte*, nint> _FetchInterfaceByName;
  /// <summary>
  /// supports both internal interface system, but also valve interface system
  /// </summary>
  public unsafe static nint FetchInterfaceByName(string ifaceName) {
    var pool = ArrayPool<byte>.Shared;
    var ifaceNameLength = Encoding.UTF8.GetByteCount(ifaceName);
    var ifaceNameBuffer = pool.Rent(ifaceNameLength + 1);
    Encoding.UTF8.GetBytes(ifaceName, ifaceNameBuffer);
    ifaceNameBuffer[ifaceNameLength] = 0;
    fixed (byte* ifaceNameBufferPtr = ifaceNameBuffer) {
        var ret = _FetchInterfaceByName(ifaceNameBufferPtr);
    pool.Return(ifaceNameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, nint> _GetVirtualTableAddress;
  public unsafe static nint GetVirtualTableAddress(string library, string vtableName) {
    var pool = ArrayPool<byte>.Shared;
    var libraryLength = Encoding.UTF8.GetByteCount(library);
    var libraryBuffer = pool.Rent(libraryLength + 1);
    Encoding.UTF8.GetBytes(library, libraryBuffer);
    libraryBuffer[libraryLength] = 0;
    fixed (byte* libraryBufferPtr = libraryBuffer) {
    
    var vtableNameLength = Encoding.UTF8.GetByteCount(vtableName);
    var vtableNameBuffer = pool.Rent(vtableNameLength + 1);
    Encoding.UTF8.GetBytes(vtableName, vtableNameBuffer);
    vtableNameBuffer[vtableNameLength] = 0;
    fixed (byte* vtableNameBufferPtr = vtableNameBuffer) {
        var ret = _GetVirtualTableAddress(libraryBufferPtr, vtableNameBufferPtr);
    pool.Return(libraryBuffer);

    pool.Return(vtableNameBuffer);

    return ret;
  }
  }
  }
}
