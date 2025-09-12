using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_PublicOutput : SchemaClass, IPulse_PublicOutput {

  public CPulse_PublicOutput(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Name {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x74B3BCA4CAE8A266));
  }
  public ref CUtlString Description {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x74B3BCA4678744E9));
  }
  public ISchemaUntypedField Args {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x74B3BCA4DAB98BBC));
  }


}