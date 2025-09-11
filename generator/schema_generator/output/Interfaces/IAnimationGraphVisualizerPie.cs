using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationGraphVisualizerPie : IAnimationGraphVisualizerPrimitiveBase {

  
  public ref VectorAligned WsCenter { get; }
  
  public ref VectorAligned WsStart { get; }
  
  public ref VectorAligned WsEnd { get; }
  
  public ref Color Color { get; }
}