using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeAntiTunnelGroupBuild_t : ISchemaClass {

  public ref uint VertexMapHash { get; }
  
  public ref uint CollisionMask { get; }
  
}