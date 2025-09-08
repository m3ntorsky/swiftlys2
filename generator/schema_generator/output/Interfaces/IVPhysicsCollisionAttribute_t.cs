using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysicsCollisionAttribute_t : ISchemaClass {

  public ref ulong InteractsAs { get; }
  
  public ref ulong InteractsWith { get; }
  
  public ref ulong InteractsExclude { get; }
  
  public ref uint EntityId { get; }
  
  public ref uint OwnerId { get; }
  
  public ref ushort HierarchyId { get; }
  
  public ref byte CollisionGroup { get; }
  
  public ref byte CollisionFunctionMask { get; }
  
}