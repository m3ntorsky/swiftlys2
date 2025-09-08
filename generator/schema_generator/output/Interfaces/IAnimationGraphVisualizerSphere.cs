using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationGraphVisualizerSphere : IAnimationGraphVisualizerPrimitiveBase {

  public ref VectorAligned WsPosition { get; }
  
  public ref float Radius { get; }
  
  public ref Color Color { get; }
  
}