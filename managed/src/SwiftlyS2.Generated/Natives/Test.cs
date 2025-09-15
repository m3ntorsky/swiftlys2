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
}
