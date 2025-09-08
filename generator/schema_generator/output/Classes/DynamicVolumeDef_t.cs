using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class DynamicVolumeDef_t : SchemaClass, IDynamicVolumeDef_t {

  public DynamicVolumeDef_t(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> Source {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x9D661554D0835C78));
  }
  public CHandle<IBaseEntity> Target {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x9D661554FA08A9E8));
  }
  public ref int HullIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9D661554595B303D));
  }
  public ref Vector SourceAnchorPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9D661554E6AC3899));
  }
  public ref Vector TargetAnchorPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9D6615540976AD91));
  }
  public ref uint AreaSrc {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9D661554E55D859E));
  }
  public ref uint AreaDst {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9D66155487799313));
  }
  public ref bool Attached {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9D6615544C8B6515));
  }


}