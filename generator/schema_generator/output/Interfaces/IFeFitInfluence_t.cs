using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeFitInfluence_t : ISchemaClass {

  
  public ref uint VertexNode { get; }
  
  public ref float Weight { get; }
  
  public ref uint MatrixNode { get; }
}