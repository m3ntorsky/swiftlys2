using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFloatClampNode__CDefinition : CNmFloatValueNode::CDefinition, INmFloatClampNode__CDefinition {

  public CNmFloatClampNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmFloatClampNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x77C3AAE295E89F27));
  }
  public ISchemaUntypedField ClampRange {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x77C3AAE2FED5C4A1));
  }


}