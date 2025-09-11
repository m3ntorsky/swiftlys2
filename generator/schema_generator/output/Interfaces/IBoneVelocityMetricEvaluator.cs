using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneVelocityMetricEvaluator : IMotionMetricEvaluator {

  
  public ref int BoneIndex { get; }
}