using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRulePointEntity : CRuleEntity, IRulePointEntity {

  public CRulePointEntity(nint handle) : base(handle) {
  }

  public ref int Score {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9E2258396C814615));
  }


}