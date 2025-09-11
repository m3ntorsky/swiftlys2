using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_StopAfterCPDuration : IParticleFunctionPreEmission {

  
  public IParticleCollectionFloatInput Duration { get; }
  
  public ref bool DestroyImmediately { get; }
  
  public ref bool PlayEndCap { get; }
}