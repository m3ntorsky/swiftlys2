using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_EntOutputHandler : CPulseCell_Inflow_BaseEntrypoint, IPulseCell_Inflow_EntOutputHandler {

  public CPulseCell_Inflow_EntOutputHandler(nint handle) : base(handle) {
  }

  public CPulseCell_Inflow_EntOutputHandler(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField SourceEntity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8C9310C4AD2DB063));
  }
  public ISchemaUntypedField SourceOutput {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8C9310C42D46D7F5));
  }
  public ISchemaUntypedField ExpectedParamType {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8C9310C41C1CB8A6));
  }


}