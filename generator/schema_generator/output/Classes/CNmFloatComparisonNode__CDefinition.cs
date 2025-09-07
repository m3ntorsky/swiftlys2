using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatComparisonNode__CDefinition : CNmBoolValueNode::CDefinition, INmFloatComparisonNode__CDefinition {

  public CNmFloatComparisonNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFloatComparisonNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x48A96E9A95E89F27));
  }
  public ref short ComparandValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x48A96E9AF7CFFAF6));
  }
  public ref CNmFloatComparisonNode::Comparison_t Comparison {
    get => ref _Handle.AsRef<CNmFloatComparisonNode::Comparison_t>(Schema.GetOffset(0x48A96E9A897F8DE4));
  }
  public ref float Epsilon {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x48A96E9A34090A67));
  }
  public ref float ComparisonValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x48A96E9A4C176B7F));
  }


}