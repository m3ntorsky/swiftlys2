using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ClutterTile_t : SchemaClass, IClutterTile_t {

  public ClutterTile_t(nint handle) : base(handle) {
  }

  public ref uint FirstInstance {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xAC4066F19AF07072));
  }
  public ref uint LastInstance {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xAC4066F10D99AC92));
  }
  public IAABB_t BoundsWs {
    get => new AABB_t(_Handle + Schema.GetOffset(0xAC4066F1BE54855A));
  }


}