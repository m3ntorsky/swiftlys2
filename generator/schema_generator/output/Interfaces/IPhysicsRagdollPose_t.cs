using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsRagdollPose_t : ISchemaClass {

  public ref CUtlVector<CTransform> Transforms { get; }
  
  public CHandle<IBaseEntity> Owner { get; }
  
  public ref bool SetFromDebugHistory { get; }
  
}