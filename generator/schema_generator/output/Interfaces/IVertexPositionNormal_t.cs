using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVertexPositionNormal_t : ISchemaClass {

  public ref Vector Position { get; }
  
  public ref Vector Normal { get; }
  
}