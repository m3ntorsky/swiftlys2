using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmOrNode__CDefinition : CNmBoolValueNode::CDefinition, INmOrNode__CDefinition {

  public CNmOrNode__CDefinition(nint handle) : base(handle) {
  }

  public ref CUtlLeanVectorFixedGrowable<int16,4> ConditionNodeIndices {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable<int16,4>>(Schema.GetOffset(0x9BF82E864A144D0F));
  }


}