using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEntityIOOutput : SchemaClass, IEntityIOOutput {

  public CEntityIOOutput(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Value {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCD5B084DCB0894A));
  }


}