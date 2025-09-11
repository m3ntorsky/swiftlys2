using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapExternalWindToCP : IParticleFunctionPreEmission {

  
  public ref int CP { get; }
  
  public ref int CPOutput { get; }
  
  public IParticleCollectionVecInput Scale { get; }
  
  public ref bool SetMagnitude { get; }
  
  public ref int OutVectorField { get; }
}