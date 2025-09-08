using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavVolumeVector : CNavVolume, INavVolumeVector {

  public CNavVolumeVector(nint handle) : base(handle) {
  }

  public ref bool HasBeenPreFiltered {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x29D8C0A2454B59CD));
  }


}