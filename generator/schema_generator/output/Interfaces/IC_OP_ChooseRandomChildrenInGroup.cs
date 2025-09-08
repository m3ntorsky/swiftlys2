using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ChooseRandomChildrenInGroup : IParticleFunctionPreEmission {

  public ref int ChildGroupID { get; }
  
  public IParticleCollectionFloatInput NumberOfChildren { get; }
  
}