using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NmSyncTrackTimeRange_t : SchemaClass, INmSyncTrackTimeRange_t {

  public NmSyncTrackTimeRange_t(nint handle) : base(handle) {
  }

  public INmSyncTrackTime_t StartTime {
    get => new NmSyncTrackTime_t(_Handle + Schema.GetOffset(0xAECBDADF6330E7EE));
  }
  public INmSyncTrackTime_t EndTime {
    get => new NmSyncTrackTime_t(_Handle + Schema.GetOffset(0xAECBDADFEAD1A94B));
  }


}