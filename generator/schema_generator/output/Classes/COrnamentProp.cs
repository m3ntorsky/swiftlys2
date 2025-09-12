using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class COrnamentProp : CDynamicProp, IOrnamentProp {

  public COrnamentProp(nint handle) : base(handle) {
  }

  public ISchemaUntypedField InitialOwner {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1B8675B7BAA055D6));
  }


}