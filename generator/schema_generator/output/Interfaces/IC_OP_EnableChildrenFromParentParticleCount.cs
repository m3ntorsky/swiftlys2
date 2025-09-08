using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_EnableChildrenFromParentParticleCount : IParticleFunctionPreEmission {

  public ref int ChildGroupID { get; }
  
  public ref int FirstChild { get; }
  
  public IParticleCollectionFloatInput NumChildrenToEnable { get; }
  
  public ref bool DisableChildren { get; }
  
  public ref bool PlayEndcapOnStop { get; }
  
  public ref bool DestroyImmediately { get; }
  
}