using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_BaseEntrypoint : CPulseCell_BaseFlow, IPulseCell_Inflow_BaseEntrypoint {

  public CPulseCell_Inflow_BaseEntrypoint(nint handle) : base(handle) {
  }

  public CPulseCell_Inflow_BaseEntrypoint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulseRuntimeChunkIndex_t EntryChunk {
    get => new PulseRuntimeChunkIndex_t(_Handle + Schema.GetOffset(0x1747DEDF279F0A60));
  }
  public IPulseRegisterMap_t RegisterMap {
    get => new PulseRegisterMap_t(_Handle + Schema.GetOffset(0x1747DEDF7BD4CE96));
  }


}