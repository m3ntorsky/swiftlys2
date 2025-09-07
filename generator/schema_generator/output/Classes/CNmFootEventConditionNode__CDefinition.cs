using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFootEventConditionNode__CDefinition : CNmBoolValueNode::CDefinition, INmFootEventConditionNode__CDefinition {

  public CNmFootEventConditionNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFootEventConditionNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xA837BCFE63F0228C));
  }
  public ref NmFootPhaseCondition_t PhaseCondition {
    get => ref _Handle.AsRef<NmFootPhaseCondition_t>(Schema.GetOffset(0xA837BCFE79D4BD7D));
  }
  public INmBitFlags EventConditionRules {
    get => new CNmBitFlags(_Handle + Schema.GetOffset(0xA837BCFEA904315F));
  }


}