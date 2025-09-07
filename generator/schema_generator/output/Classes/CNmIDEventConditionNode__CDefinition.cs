using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDEventConditionNode__CDefinition : CNmBoolValueNode::CDefinition, INmIDEventConditionNode__CDefinition {

  public CNmIDEventConditionNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmIDEventConditionNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xBD2C5F7563F0228C));
  }
  public INmBitFlags EventConditionRules {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0xBD2C5F75A904315F));
  }
  public ref CUtlVectorFixedGrowable< CGlobalSymbol, 5 > EventIDs {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< CGlobalSymbol, 5 >>(Schema.GetOffset(0xBD2C5F75E7543F93));
  }


}