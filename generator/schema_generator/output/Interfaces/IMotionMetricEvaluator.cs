using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionMetricEvaluator : ISchemaClass {

  public ref CUtlVector<float> Means { get; }
  
  public ref CUtlVector<float> StandardDeviations { get; }
  
  public ref float Weight { get; }
  
  public ref int DimensionStartIndex { get; }
  
}