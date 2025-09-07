using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFootstepEventPercentageThroughNode__CDefinition : CNmFloatValueNode::CDefinition, INmFootstepEventPercentageThroughNode__CDefinition {

  public CNmFootstepEventPercentageThroughNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFootstepEventPercentageThroughNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x998F83E463F0228C));
  }
  public ref NmFootPhaseCondition_t PhaseCondition {
    get => ref _Handle.AsRef<NmFootPhaseCondition_t>(Schema.GetOffset(0x998F83E479D4BD7D));
  }
  public INmBitFlags EventConditionRules {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0x998F83E4A904315F));
  }


}