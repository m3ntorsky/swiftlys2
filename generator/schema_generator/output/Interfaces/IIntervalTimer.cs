using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IIntervalTimer : ISchemaClass {

  public IGameTime_t Timestamp { get; }
  
  public ref WorldGroupId_t WorldGroupId { get; }
  
}