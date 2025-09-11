using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSyncTrackTime_t : ISchemaClass {

  
  public ref int EventIdx { get; }
  
  public INmPercent_t PercentageThrough { get; }
}