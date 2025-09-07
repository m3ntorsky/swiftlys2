using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_CycleShuffled : CPulseCell_BaseFlow, IPulseCell_Outflow_CycleShuffled {

  public CPulseCell_Outflow_CycleShuffled(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_CycleShuffled(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CPulse_OutflowConnection > Outputs {
    get => ref _Handle.AsRef<CUtlVector< CPulse_OutflowConnection >>(Schema.GetOffset(0xA7823F26A38A89D5));
  }


}