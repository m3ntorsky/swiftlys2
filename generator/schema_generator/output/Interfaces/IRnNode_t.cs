using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnNode_t : ISchemaClass {

  public ref Vector Min { get; }
  
  public ref uint Children { get; }
  
  public ref Vector Max { get; }
  
  public ref uint TriangleOffset { get; }
  
}