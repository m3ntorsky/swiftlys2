using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEngineCountdownTimer : ISchemaClass {

  
  public ref float Duration { get; }
  
  public ref float Timestamp { get; }
  
  public ref float Timescale { get; }
}