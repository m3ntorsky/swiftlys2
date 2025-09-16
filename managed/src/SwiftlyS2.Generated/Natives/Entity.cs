#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeEntity {
  private unsafe static delegate* unmanaged<void*, bool> _HandleIsValid;
  public unsafe static bool HandleIsValid(void* handle) {
    var ret = _HandleIsValid(handle);
    return ret;
  }
  private unsafe static delegate* unmanaged<void*, void*> _HandleGet;
  public unsafe static void* HandleGet(void* handle) {
    var ret = _HandleGet(handle);
    return ret;
  }
}
