using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicLineToEntity : CLogicalEntity, ILogicLineToEntity {

  public CLogicLineToEntity(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Line {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x61067DC85589FAA7));
  }
  public ISchemaUntypedField SourceName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x61067DC82F9BA2DB));
  }
  public ref CHandle<CBaseEntity> StartEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x61067DC8904F2828));
  }
  public ref CHandle<CBaseEntity> EndEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x61067DC89114A219));
  }


}