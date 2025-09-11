using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSyncTrack__EventMarker_t : ISchemaClass {

  
  public INmPercent_t StartTime { get; }
  
  public ref CGlobalSymbol ID { get; }
}