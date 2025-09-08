using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeRigidColliderIndices_t : ISchemaClass {

  public ref ushort TaperedCapsuleRigidIndex { get; }
  
  public ref ushort SphereRigidIndex { get; }
  
  public ref ushort BoxRigidIndex { get; }
  
  public ref ushort SDFRigidIndex { get; }
  
  public ref ushort CollisionPlaneIndex { get; }
  
}