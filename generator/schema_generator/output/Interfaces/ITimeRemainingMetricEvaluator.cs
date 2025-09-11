using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITimeRemainingMetricEvaluator : IMotionMetricEvaluator {

  
  public ref bool MatchByTimeRemaining { get; }
  
  public ref float MaxTimeRemaining { get; }
  
  public ref bool FilterByTimeRemaining { get; }
  
  public ref float MinTimeRemaining { get; }
}