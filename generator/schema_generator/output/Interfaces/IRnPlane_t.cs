using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnPlane_t : ISchemaClass {

  public ref Vector Normal { get; }
  
  public ref float Offset { get; }
  
}