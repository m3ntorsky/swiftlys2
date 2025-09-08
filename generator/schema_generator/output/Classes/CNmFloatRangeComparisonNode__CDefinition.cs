using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatRangeComparisonNode__CDefinition : CNmBoolValueNode::CDefinition, INmFloatRangeComparisonNode__CDefinition {

  public CNmFloatRangeComparisonNode__CDefinition(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Range {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6F364CB3D639CF2));
  }
  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x6F364CB95E89F27));
  }
  public ref bool IsInclusiveCheck {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6F364CBA95FA7C3));
  }


}