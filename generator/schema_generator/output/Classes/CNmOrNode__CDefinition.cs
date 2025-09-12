using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmOrNode__CDefinition : CNmBoolValueNode::CDefinition, INmOrNode__CDefinition {

  public CNmOrNode__CDefinition(nint handle) : base(handle) {
  }

  public ISchemaUntypedField ConditionNodeIndices {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x9BF82E864A144D0F));
  }


}