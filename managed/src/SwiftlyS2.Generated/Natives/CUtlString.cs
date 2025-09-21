#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeCUtlString {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<nint, byte*, void> _Set;
  public unsafe static void Set(nint utlstring, string str) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var strLength = Encoding.UTF8.GetByteCount(str);
    var strBuffer = pool.Rent(strLength + 1);
    Encoding.UTF8.GetBytes(str, strBuffer);
    strBuffer[strLength] = 0;
    fixed (byte* strBufferPtr = strBuffer) {
        _Set(utlstring, strBufferPtr);
    pool.Return(strBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _Purge;
  public unsafe static void Purge(nint utlstring) {
    try {
    _Purge(utlstring);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, int, void> _SetDirect;
  public unsafe static void SetDirect(nint utlstring, string str, int len) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var strLength = Encoding.UTF8.GetByteCount(str);
    var strBuffer = pool.Rent(strLength + 1);
    Encoding.UTF8.GetBytes(str, strBuffer);
    strBuffer[strLength] = 0;
    fixed (byte* strBufferPtr = strBuffer) {
        _SetDirect(utlstring, strBufferPtr, len);
    pool.Return(strBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
