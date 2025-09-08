using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRelativeLocation : SchemaClass, IRelativeLocation {

  public CRelativeLocation(nint handle) : base(handle) {
  }

  public ref RelativeLocationType_t Type {
    get => ref _Handle.AsRef<RelativeLocationType_t>(Schema.GetOffset(0xA25CE2418ED6D5CD));
  }
  public ref Vector RelativeOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA25CE241B6F2D296));
  }
  public ref Vector WorldSpacePos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA25CE2410A43E96B));
  }
  public ref CHandle<CBaseEntity> Entity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xA25CE2416EBADCB0));
  }


}