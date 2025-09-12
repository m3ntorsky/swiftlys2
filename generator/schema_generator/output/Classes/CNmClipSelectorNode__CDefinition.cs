using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmClipSelectorNode__CDefinition : CNmClipReferenceNode::CDefinition, INmClipSelectorNode__CDefinition {

  public CNmClipSelectorNode__CDefinition(nint handle) : base(handle) {
  }

  public ISchemaUntypedField OptionNodeIndices {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCF32AC18DA97B15D));
  }
  public ISchemaUntypedField ConditionNodeIndices {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCF32AC184A144D0F));
  }


}