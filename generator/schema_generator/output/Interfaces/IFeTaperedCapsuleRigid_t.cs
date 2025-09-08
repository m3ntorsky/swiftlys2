using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeTaperedCapsuleRigid_t : ISchemaClass {

  public ISchemaFixedArray<fltx4> Sphere { get; }
  
  public ref ushort Node { get; }
  
  public ref ushort CollisionMask { get; }
  
  public ref ushort VertexMapIndex { get; }
  
  public ref ushort Flags { get; }
  
}