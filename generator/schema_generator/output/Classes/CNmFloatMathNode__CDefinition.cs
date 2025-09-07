using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatMathNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatMathNode__CDefinition {

  public CNmFloatMathNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFloatMathNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdxA {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x8A1F4F076332ED92));
  }
  public ref short InputValueNodeIdxB {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x8A1F4F076232EBFF));
  }
  public ref bool ReturnAbsoluteResult {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8A1F4F07065EA6EB));
  }
  public ref bool ReturnNegatedResult {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8A1F4F07535A6CA2));
  }
  public ref CNmFloatMathNode::Operator_t Operator {
    get => ref _Handle.AsRef<CNmFloatMathNode::Operator_t>(Schema.GetOffset(0x8A1F4F078ABE049D));
  }
  public ref float ValueB {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8A1F4F074AD872B2));
  }


}