#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeSignatures {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<byte*, bool> _Exists;
  public unsafe static bool Exists(string signatureName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var signatureNameLength = Encoding.UTF8.GetByteCount(signatureName);
    var signatureNameBuffer = pool.Rent(signatureNameLength + 1);
    Encoding.UTF8.GetBytes(signatureName, signatureNameBuffer);
    signatureNameBuffer[signatureNameLength] = 0;
    fixed (byte* signatureNameBufferPtr = signatureNameBuffer) {
        var ret = _Exists(signatureNameBufferPtr);
    pool.Return(signatureNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, nint> _Fetch;
  public unsafe static nint Fetch(string signatureName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var signatureNameLength = Encoding.UTF8.GetByteCount(signatureName);
    var signatureNameBuffer = pool.Rent(signatureNameLength + 1);
    Encoding.UTF8.GetBytes(signatureName, signatureNameBuffer);
    signatureNameBuffer[signatureNameLength] = 0;
    fixed (byte* signatureNameBufferPtr = signatureNameBuffer) {
        var ret = _Fetch(signatureNameBufferPtr);
    pool.Return(signatureNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
