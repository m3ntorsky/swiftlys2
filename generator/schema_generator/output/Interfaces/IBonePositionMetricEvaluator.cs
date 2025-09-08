using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBonePositionMetricEvaluator : IMotionMetricEvaluator {

  public ref int BoneIndex { get; }
  
}