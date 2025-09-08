using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointProximitySensor : CPointEntity, IPointProximitySensor {

  public CPointProximitySensor(nint handle) : base(handle) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x769A8B133A7C5965));
  }
  public ref CHandle<CBaseEntity> TargetEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x769A8B1325D042A9));
  }
  public ISchemaUntypedField Distance {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x769A8B13978BC0E2));
  }


}