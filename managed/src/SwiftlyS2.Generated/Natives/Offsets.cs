#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeOffsets {
  private unsafe static delegate* unmanaged<byte*, bool> _Exists;
  public unsafe static bool Exists(string name) {
    var pool = ArrayPool<byte>.Shared;
    var nameLength = Encoding.UTF8.GetByteCount(name);
    var nameBuffer = pool.Rent(nameLength + 1);
    Encoding.UTF8.GetBytes(name, nameBuffer);
    nameBuffer[nameLength] = 0;
    fixed (byte* nameBufferPtr = nameBuffer) {
    var ret = _Exists(nameBufferPtr);
    pool.Return(nameBuffer);

    return ret;
  }
  }
  private unsafe static delegate* unmanaged<byte*, int> _Fetch;
  public unsafe static int Fetch(string name) {
    var pool = ArrayPool<byte>.Shared;
    var nameLength = Encoding.UTF8.GetByteCount(name);
    var nameBuffer = pool.Rent(nameLength + 1);
    Encoding.UTF8.GetBytes(name, nameBuffer);
    nameBuffer[nameLength] = 0;
    fixed (byte* nameBufferPtr = nameBuffer) {
    var ret = _Fetch(nameBufferPtr);
    pool.Return(nameBuffer);

    return ret;
  }
  }
}
