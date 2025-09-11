using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeBoxRigid_t : ISchemaClass {

  
  public ref CTransform TmFrame2 { get; }
  
  public ref ushort Node { get; }
  
  public ref ushort CollisionMask { get; }
  
  public ref Vector Size { get; }
  
  public ref ushort VertexMapIndex { get; }
  
  public ref ushort Flags { get; }
}