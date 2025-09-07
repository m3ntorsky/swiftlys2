using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSyncTrack : SchemaClass, INmSyncTrack {

  public CNmSyncTrack(nint handle) : base(handle) {
  }

  public CNmSyncTrack(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlLeanVectorFixedGrowable< CNmSyncTrack::Event_t, 10 > SyncEvents {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< CNmSyncTrack::Event_t, 10 >>(Schema.GetOffset(0x29C7FA0336BAB4FF));
  }
  public ref int StartEventOffset {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x29C7FA03DDBC640E));
  }


}