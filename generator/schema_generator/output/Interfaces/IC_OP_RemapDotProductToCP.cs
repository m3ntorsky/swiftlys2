using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapDotProductToCP : IParticleFunctionPreEmission {

  public ref int InputCP1 { get; }
  
  public ref int InputCP2 { get; }
  
  public ref int OutputCP { get; }
  
  public ref int OutVectorField { get; }
  
  public IParticleCollectionFloatInput InputMin { get; }
  
  public IParticleCollectionFloatInput InputMax { get; }
  
  public IParticleCollectionFloatInput OutputMin { get; }
  
  public IParticleCollectionFloatInput OutputMax { get; }
  
}