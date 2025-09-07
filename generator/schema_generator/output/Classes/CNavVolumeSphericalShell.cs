using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavVolumeSphericalShell : CNavVolumeSphere, INavVolumeSphericalShell {

  public CNavVolumeSphericalShell(nint handle) : base(handle) {
  }

  public CNavVolumeSphericalShell(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float RadiusInner {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8AC7FC7A5D85234F));
  }


}