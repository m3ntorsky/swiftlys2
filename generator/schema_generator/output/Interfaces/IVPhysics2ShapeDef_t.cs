using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysics2ShapeDef_t : ISchemaClass {

  public ref CUtlVector Spheres { get; }
  
  public ref CUtlVector Capsules { get; }
  
  public ref CUtlVector Hulls { get; }
  
  public ref CUtlVector Meshes { get; }
  
  public ref CUtlVector<ushort> CollisionAttributeIndices { get; }
  
}