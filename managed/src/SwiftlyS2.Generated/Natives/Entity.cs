#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeEntity {
  private unsafe static delegate* unmanaged<nint, bool> _HandleIsValid;
  public unsafe static bool HandleIsValid(nint handle) {
    var ret = _HandleIsValid(handle);
    return ret;
  }
  private unsafe static delegate* unmanaged<nint, nint> _HandleGet;
  public unsafe static nint HandleGet(nint handle) {
    var ret = _HandleGet(handle);
    return ret;
  }
}
