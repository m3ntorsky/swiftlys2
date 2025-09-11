using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSoftbodyDesc_t : ISchemaClass {

  
  public ref CUtlVector<uint> ParticleBoneHash { get; }
  
// CUtlVector< RnSoftbodyParticle_t >
  public ref CUtlVector Particles { get; }
  
// CUtlVector< RnSoftbodySpring_t >
  public ref CUtlVector Springs { get; }
  
// CUtlVector< RnSoftbodyCapsule_t >
  public ref CUtlVector Capsules { get; }
  
  public ref CUtlVector<CTransform> InitPose { get; }
  
  public ref CUtlVector<CUtlString> ParticleBoneName { get; }
}