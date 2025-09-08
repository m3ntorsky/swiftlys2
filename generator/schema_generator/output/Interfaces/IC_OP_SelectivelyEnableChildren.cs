using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SelectivelyEnableChildren : IParticleFunctionPreEmission {

  public IParticleCollectionFloatInput ChildGroupID { get; }
  
  public IParticleCollectionFloatInput FirstChild { get; }
  
  public IParticleCollectionFloatInput NumChildrenToEnable { get; }
  
  public ref bool PlayEndcapOnStop { get; }
  
  public ref bool DestroyImmediately { get; }
  
}