using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIDToFloatNode__CDefinition : CNmFloatValueNode::CDefinition, INmIDToFloatNode__CDefinition {

  public CNmIDToFloatNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short InputValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9F6F687D95E89F27));
  }
  public ref float DefaultValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9F6F687DBBE0341F));
  }
  public ISchemaUntypedField IDs {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x9F6F687D0C180009));
  }
  public ISchemaUntypedField Values {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x9F6F687DFBEDDADB));
  }


}