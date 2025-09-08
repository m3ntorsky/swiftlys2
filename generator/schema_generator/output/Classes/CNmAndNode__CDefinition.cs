using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmAndNode__CDefinition : CNmBoolValueNode::CDefinition, INmAndNode__CDefinition {

  public CNmAndNode__CDefinition(nint handle) : base(handle) {
  }

  public ref CUtlLeanVectorFixedGrowable<int16,4> ConditionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<int16,4>>(Schema.GetOffset(0xC46B12E04A144D0F));
  }


}