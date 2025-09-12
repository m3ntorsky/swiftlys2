using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSelectorNode__CDefinition : CNmPoseNode::CDefinition, INmSelectorNode__CDefinition {

  public CNmSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public ISchemaUntypedField OptionNodeIndices {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4E964386DA97B15D));
  }
  public ISchemaUntypedField ConditionNodeIndices {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4E9643864A144D0F));
  }


}