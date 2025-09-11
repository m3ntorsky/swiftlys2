using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationGraphVisualizerAxis : IAnimationGraphVisualizerPrimitiveBase {

  
  public ref CTransform XWsTransform { get; }
  
  public ref float AxisSize { get; }
}