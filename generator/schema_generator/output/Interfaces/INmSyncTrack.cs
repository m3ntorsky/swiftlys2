using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSyncTrack : ISchemaClass {

  
  public ref CUtlLeanVectorFixedGrowable<CNmSyncTrack::Event_t,10> SyncEvents { get; }
  
  public ref int StartEventOffset { get; }
}