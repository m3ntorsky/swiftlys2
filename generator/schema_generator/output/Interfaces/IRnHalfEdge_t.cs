using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnHalfEdge_t : ISchemaClass {

  
  public ref byte Next { get; }
  
  public ref byte Twin { get; }
  
  public ref byte Origin { get; }
  
  public ref byte Face { get; }
}