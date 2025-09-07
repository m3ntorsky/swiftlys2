using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_EventHandler : CPulseCell_Inflow_BaseEntrypoint, IPulseCell_Inflow_EventHandler {

  public CPulseCell_Inflow_EventHandler(nint handle) : base(handle) {
  }

  public CPulseCell_Inflow_EventHandler(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField EventName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x9BAF9AD81DFEB13C));
  }


}