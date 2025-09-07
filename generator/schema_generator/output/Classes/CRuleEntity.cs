using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRuleEntity : CBaseModelEntity, IRuleEntity {

  public CRuleEntity(nint handle) : base(handle) {
  }

  public CRuleEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge Master {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x5C9BFE2FAC57FE5B));
  }


}