using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationGraphVisualizerPrimitiveBase : ISchemaClass {

  public ref CAnimationGraphVisualizerPrimitiveType Type { get; }
  
  public IAnimNodeID OwningAnimNodePaths { get; }
  
  public ref int OwningAnimNodePathCount { get; }
  
}