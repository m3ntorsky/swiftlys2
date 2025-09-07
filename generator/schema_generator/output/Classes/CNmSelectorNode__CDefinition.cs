using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSelectorNode__CDefinition : CNmPoseNode::CDefinition, INmSelectorNode__CDefinition {

  public CNmSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmSelectorNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlLeanVectorFixedGrowable< int16, 5 > OptionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< int16, 5 >>(Schema.GetOffset(0x4E964386DA97B15D));
  }
  public ref CUtlLeanVectorFixedGrowable< int16, 5 > ConditionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< int16, 5 >>(Schema.GetOffset(0x4E9643864A144D0F));
  }


}