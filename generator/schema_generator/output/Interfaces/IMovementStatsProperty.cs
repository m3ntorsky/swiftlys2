using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMovementStatsProperty : ISchemaClass {

  public ref int UseCounter { get; }
  
  public IVectorExponentialMovingAverage EmaMovementDirection { get; }
  
}