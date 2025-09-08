using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTimeConditionNode__CDefinition : CNmBoolValueNode::CDefinition, INmTimeConditionNode__CDefinition {

  public CNmTimeConditionNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short SourceStateNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x421E2145D1DB8128));
  }
  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x421E214595E89F27));
  }
  public ref float Comparand {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x421E21450CF10B48));
  }
  public ref CNmTimeConditionNode::ComparisonType_t Type {
    get => ref _Handle.AsRef<CNmTimeConditionNode::ComparisonType_t>(Schema.GetOffset(0x421E21450F04B4ED));
  }
  public ref CNmTimeConditionNode::Operator_t Operator {
    get => ref _Handle.AsRef<CNmTimeConditionNode::Operator_t>(Schema.GetOffset(0x421E21458ABE049D));
  }


}