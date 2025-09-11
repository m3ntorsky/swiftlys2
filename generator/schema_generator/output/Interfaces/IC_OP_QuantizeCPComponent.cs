using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_QuantizeCPComponent : IParticleFunctionPreEmission {

  
  public IParticleCollectionFloatInput InputValue { get; }
  
  public ref int CPOutput { get; }
  
  public ref int OutVectorField { get; }
  
  public IParticleCollectionFloatInput QuantizeValue { get; }
}