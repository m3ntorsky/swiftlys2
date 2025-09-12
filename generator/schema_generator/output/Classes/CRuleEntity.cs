using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRuleEntity : CBaseModelEntity, IRuleEntity {

  public CRuleEntity(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Master {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x5C9BFE2FAC57FE5B));
  }


}