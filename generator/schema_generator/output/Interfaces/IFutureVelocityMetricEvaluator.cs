using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFutureVelocityMetricEvaluator : IMotionMetricEvaluator {

  
  public ref float Distance { get; }
  
  public ref float StoppingDistance { get; }
  
  public ref float TargetSpeed { get; }
  
  public ref VelocityMetricMode Mode { get; }
}