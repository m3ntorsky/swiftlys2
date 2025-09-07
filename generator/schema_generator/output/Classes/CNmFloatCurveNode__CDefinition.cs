using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatCurveNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatCurveNode__CDefinition {

  public CNmFloatCurveNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFloatCurveNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x34D6839A95E89F27));
  }
  public ISchemaUntypedField Curve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x34D6839ABFFA0B34));
  }


}