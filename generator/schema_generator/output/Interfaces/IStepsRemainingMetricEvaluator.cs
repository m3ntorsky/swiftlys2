using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStepsRemainingMetricEvaluator : IMotionMetricEvaluator {

  public ref CUtlVector<int> FootIndices { get; }
  
  public ref float MinStepsRemaining { get; }
  
}