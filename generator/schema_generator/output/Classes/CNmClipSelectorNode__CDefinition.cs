using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmClipSelectorNode__CDefinition : CNmClipReferenceNode::CDefinition, INmClipSelectorNode__CDefinition {

  public CNmClipSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public ref CUtlLeanVectorFixedGrowable<int16,5> OptionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<int16,5>>(Schema.GetOffset(0xCF32AC18DA97B15D));
  }
  public ref CUtlLeanVectorFixedGrowable<int16,5> ConditionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<int16,5>>(Schema.GetOffset(0xCF32AC184A144D0F));
  }


}