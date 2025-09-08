using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_CycleShuffled__InstanceState_t : SchemaClass, IPulseCell_Outflow_CycleShuffled__InstanceState_t {

  public CPulseCell_Outflow_CycleShuffled__InstanceState_t(nint handle) : base(handle) {
  }

  public ref CUtlVectorFixedGrowable<byte> Shuffle {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable<byte>>(Schema.GetOffset(0xD33F67BD200E9ACE));
  }
  public ref int NextShuffle {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD33F67BD741282A5));
  }


}