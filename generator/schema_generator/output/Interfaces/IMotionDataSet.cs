using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionDataSet : ISchemaClass {

  public ref CUtlVector Groups { get; }
  
  public ref int DimensionCount { get; }
  
}