using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_GraphHook : CPulseCell_Inflow_BaseEntrypoint, IPulseCell_Inflow_GraphHook {

  public CPulseCell_Inflow_GraphHook(nint handle) : base(handle) {
  }

  public ISchemaUntypedField HookName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEA4B2E6FA19F4D11));
  }


}