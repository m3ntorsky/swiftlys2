using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationGraphVisualizerLine : IAnimationGraphVisualizerPrimitiveBase {

  
  public ref VectorAligned WsPositionStart { get; }
  
  public ref VectorAligned WsPositionEnd { get; }
  
  public ref Color Color { get; }
}