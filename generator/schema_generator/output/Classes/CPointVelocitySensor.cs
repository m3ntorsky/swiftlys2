using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointVelocitySensor : CPointEntity, IPointVelocitySensor {

  public CPointVelocitySensor(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> TargetEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x96CA232125D042A9));
  }
  public ref Vector Axis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x96CA23210AF9CE54));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x96CA23216154EB7E));
  }
  public ref float PrevVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x96CA23211F9ACE5F));
  }
  public ref float AvgInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x96CA2321D6693004));
  }
  public ISchemaUntypedField Velocity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x96CA23219B4CC8B2));
  }


}