using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSoftbodyDesc_t : ISchemaClass {

  public ref CUtlVector<uint> ParticleBoneHash { get; }
  
  public ref CUtlVector Particles { get; }
  
  public ref CUtlVector Springs { get; }
  
  public ref CUtlVector Capsules { get; }
  
  public ref CUtlVector<CTransform> InitPose { get; }
  
  public ref CUtlVector<CUtlString> ParticleBoneName { get; }
  
}