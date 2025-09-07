using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatSelectorNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatSelectorNode__CDefinition {

  public CNmFloatSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFloatSelectorNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVectorFixedGrowable< int16, 5 > ConditionNodeIndices {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< int16, 5 >>(Schema.GetOffset(0xA387F8324A144D0F));
  }
  public ref CUtlVectorFixedGrowable< float32, 5 > Values {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< float32, 5 >>(Schema.GetOffset(0xA387F832FBEDDADB));
  }
  public ref float DefaultValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA387F832700AB429));
  }
  public ref float EaseTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA387F832D0A54FCC));
  }
  public ref NmEasingOperation_t EasingOp {
    get => ref _Handle.AsRef<NmEasingOperation_t>(Schema.GetOffset(0xA387F832CF457EAF));
  }


}