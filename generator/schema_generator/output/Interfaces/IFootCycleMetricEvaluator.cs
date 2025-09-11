using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootCycleMetricEvaluator : IMotionMetricEvaluator {

  
  public ref CUtlVector<int> FootIndices { get; }
}