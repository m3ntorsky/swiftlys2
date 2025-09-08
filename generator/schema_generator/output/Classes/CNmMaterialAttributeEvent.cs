using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmMaterialAttributeEvent : CNmEvent, INmMaterialAttributeEvent {

  public CNmMaterialAttributeEvent(nint handle) : base(handle) {
  }

  public ref CUtlString AttributeName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xFC131DA9168F02C));
  }
  public ref CUtlStringToken AttributeNameToken {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0xFC131DA4C1F86C9));
  }
  public ISchemaUntypedField X {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC131DADBC57BA7));
  }
  public ISchemaUntypedField Y {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC131DADAC57A14));
  }
  public ISchemaUntypedField Z {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC131DADDC57ECD));
  }
  public ISchemaUntypedField W {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFC131DAD0C56A56));
  }


}