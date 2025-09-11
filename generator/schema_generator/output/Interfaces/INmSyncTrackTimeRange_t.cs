using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSyncTrackTimeRange_t : ISchemaClass {

  
  public INmSyncTrackTime_t StartTime { get; }
  
  public INmSyncTrackTime_t EndTime { get; }
}