using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_BoxConstraint : IParticleFunctionConstraint {

  public IParticleCollectionVecInput Min { get; }
  
  public IParticleCollectionVecInput Max { get; }
  
  public ref int CP { get; }
  
  public ref bool LocalSpace { get; }
  
  public ref bool AccountForRadius { get; }
  
}