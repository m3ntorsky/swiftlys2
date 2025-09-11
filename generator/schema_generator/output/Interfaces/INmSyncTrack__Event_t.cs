using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSyncTrack__Event_t : ISchemaClass {

  
  public ref CGlobalSymbol ID { get; }
  
  public INmPercent_t StartTime { get; }
  
  public INmPercent_t Duration { get; }
}