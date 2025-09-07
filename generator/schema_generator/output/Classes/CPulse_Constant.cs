using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_Constant : SchemaClass, IPulse_Constant {

  public CPulse_Constant(nint handle) : base(handle) {
  }

  public CPulse_Constant(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Type {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x28B1B9F08ED6D5CD));
  }
  public ISchemaUntypedField Value {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x28B1B9F0DCB0894A));
  }


}