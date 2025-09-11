using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysics2ShapeDef_t : ISchemaClass {

  
// CUtlVector< RnSphereDesc_t >
  public ref CUtlVector Spheres { get; }
  
// CUtlVector< RnCapsuleDesc_t >
  public ref CUtlVector Capsules { get; }
  
// CUtlVector< RnHullDesc_t >
  public ref CUtlVector Hulls { get; }
  
// CUtlVector< RnMeshDesc_t >
  public ref CUtlVector Meshes { get; }
  
  public ref CUtlVector<ushort> CollisionAttributeIndices { get; }
}