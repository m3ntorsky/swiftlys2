using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSphereRigid_t : ISchemaClass {

  public ref fltx4 Sphere { get; }
  
  public ref ushort Node { get; }
  
  public ref ushort CollisionMask { get; }
  
  public ref ushort VertexMapIndex { get; }
  
  public ref ushort Flags { get; }
  
}