using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDComparisonNode__CDefinition : CNmBoolValueNode::CDefinition, INmIDComparisonNode__CDefinition {

  public CNmIDComparisonNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE0D928B595E89F27));
  }
  public ref CNmIDComparisonNode::Comparison_t Comparison {
    get => ref _Handle.AsRef<CNmIDComparisonNode::Comparison_t>(Schema.GetOffset(0xE0D928B5897F8DE4));
  }
  public ref CUtlLeanVectorFixedGrowable<CGlobalSymbol,4> ComparisionIDs {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<CGlobalSymbol,4>>(Schema.GetOffset(0xE0D928B5E68D53FD));
  }


}