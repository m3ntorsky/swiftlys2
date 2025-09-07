using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmGraphEventConditionNode__CDefinition : CNmBoolValueNode::CDefinition, INmGraphEventConditionNode__CDefinition {

  public CNmGraphEventConditionNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmGraphEventConditionNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x8806734863F0228C));
  }
  public INmBitFlags EventConditionRules {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0x88067348A904315F));
  }
  public ref CUtlVectorFixedGrowable< CNmGraphEventConditionNode::Condition_t, 5 > Conditions {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< CNmGraphEventConditionNode::Condition_t, 5 >>(Schema.GetOffset(0x88067348EDDF6757));
  }


}