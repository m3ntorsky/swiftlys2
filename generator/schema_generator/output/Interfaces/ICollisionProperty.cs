using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICollisionProperty : ISchemaClass {

  
  public IVPhysicsCollisionAttribute_t CollisionAttribute { get; }
  
  public ref Vector Mins { get; }
  
  public ref Vector Maxs { get; }
  
  public ref byte SolidFlags { get; }
  
  public ref SolidType_t SolidType { get; }
  
  public ref byte TriggerBloat { get; }
  
  public ref SurroundingBoundsType_t SurroundType { get; }
  
  public ref byte CollisionGroup { get; }
  
  public ref byte EnablePhysics { get; }
  
  public ref float BoundingRadius { get; }
  
  public ref Vector SpecifiedSurroundingMins { get; }
  
  public ref Vector SpecifiedSurroundingMaxs { get; }
  
  public ref Vector SurroundingMaxs { get; }
  
  public ref Vector SurroundingMins { get; }
  
  public ref Vector CapsuleCenter1 { get; }
  
  public ref Vector CapsuleCenter2 { get; }
  
  public ref float CapsuleRadius { get; }
}