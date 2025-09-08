using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootPositionMetricEvaluator : IMotionMetricEvaluator {

  public ref CUtlVector<int> FootIndices { get; }
  
  public ref bool IgnoreSlope { get; }
  
}