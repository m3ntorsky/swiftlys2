#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeTranslations {
  private unsafe static delegate* unmanaged<byte*, byte*, int, int> _Fetch;
  public unsafe static string Fetch(string key, int playerid) {
    var pool = ArrayPool<byte>.Shared;
    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    var ret = _Fetch(null, keyBufferPtr, playerid);

    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _Fetch(retBufferPtr, keyBufferPtr, playerid);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    pool.Return(keyBuffer);

    return retString;
  }
  }
  }
}
