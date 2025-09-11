using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathMetricEvaluator : IMotionMetricEvaluator {

  
  public ref CUtlVector<float> PathTimeSamples { get; }
  
  public ref float Distance { get; }
  
  public ref bool ExtrapolateMovement { get; }
  
  public ref float MinExtrapolationSpeed { get; }
}