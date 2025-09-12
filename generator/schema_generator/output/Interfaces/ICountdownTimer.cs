using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICountdownTimer : ISchemaClass {

  
  public ref float Duration { get; }
  
  public IGameTime_t Timestamp { get; }
  
  public ref float Timescale { get; }
  
  public ref uint WorldGroupId { get; }
}