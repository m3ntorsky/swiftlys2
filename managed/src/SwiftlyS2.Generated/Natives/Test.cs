#pragma warning disable CS0649

using System.Buffers;
using System.Text;

namespace SwiftlyS2.Core.Natives;

internal static class NativeTest {
  private unsafe static delegate* unmanaged<void*> _Test;
  public unsafe static void* Test() {
    var ret = _Test();
    return ret;
  }
  private unsafe static delegate* unmanaged<byte*, byte*, int> _TestVariant;
  public unsafe static NativeVariantType TestVariant(NativeVariantType v) {
    var pool = ArrayPool<byte>.Shared;
    var vBuffer = pool.Rent(v.GetSerializationSize());
    fixed (byte* vBufferPtr = vBuffer) {
    v.Serialize((nint)vBufferPtr);
    var ret = _TestVariant(null, vBufferPtr);

    var retBuffer = pool.Rent(ret);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _TestVariant(retBufferPtr, vBufferPtr);
    var retVariant = NativeVariantType.Deserialize((nint)retBufferPtr);
    pool.Return(retBuffer);

    pool.Return(vBuffer);

    return retVariant;
  }
  }
  }
}
