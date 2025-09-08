using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationGraphVisualizerText : IAnimationGraphVisualizerPrimitiveBase {

  public ref VectorAligned WsPosition { get; }
  
  public ref Color Color { get; }
  
  public ref CUtlString Text { get; }
  
}