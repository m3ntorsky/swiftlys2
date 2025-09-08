using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseRuntimeMethodArg : SchemaClass, IPulseRuntimeMethodArg {

  public CPulseRuntimeMethodArg(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Name {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA8B175BCCAE8A266));
  }
  public ref CUtlString Description {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA8B175BC678744E9));
  }
  public ISchemaUntypedField Type {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA8B175BC8ED6D5CD));
  }


}