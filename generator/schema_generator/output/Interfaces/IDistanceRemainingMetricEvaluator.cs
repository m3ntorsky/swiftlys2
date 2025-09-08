using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDistanceRemainingMetricEvaluator : IMotionMetricEvaluator {

  public ref float MaxDistance { get; }
  
  public ref float MinDistance { get; }
  
  public ref float StartGoalFilterDistance { get; }
  
  public ref float MaxGoalOvershootScale { get; }
  
  public ref bool FilterFixedMinDistance { get; }
  
  public ref bool FilterGoalDistance { get; }
  
  public ref bool FilterGoalOvershoot { get; }
  
}