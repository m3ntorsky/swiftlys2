using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointRotation : IParticleFunctionPreEmission {

  public IParticleCollectionVecInput RotAxis { get; }
  
  public IParticleCollectionFloatInput RotRate { get; }
  
  public ref int CP { get; }
  
  public ref int LocalCP { get; }
  
}