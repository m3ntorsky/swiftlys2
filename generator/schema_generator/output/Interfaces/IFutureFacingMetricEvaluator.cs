using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFutureFacingMetricEvaluator : IMotionMetricEvaluator {

  public ref float Distance { get; }
  
  public ref float Time { get; }
  
}