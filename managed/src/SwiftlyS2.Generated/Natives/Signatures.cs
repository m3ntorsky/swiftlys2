using System.Buffers;
using System.Text;

namespace SwiftlyS2.Natives;

public static class NativeSignatures {
  private unsafe static delegate* unmanaged<byte*, bool> _Exists;
  public unsafe static bool Exists(string signatureName) {
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
  }
  private unsafe static delegate* unmanaged<byte*, void*> _Fetch;
  public unsafe static void* Fetch(string signatureName) {
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
  }
}
