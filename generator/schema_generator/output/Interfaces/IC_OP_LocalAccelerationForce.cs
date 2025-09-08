using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LocalAccelerationForce : IParticleFunctionForce {

  public ref int CP { get; }
  
  public ref int ScaleCP { get; }
  
  public IParticleCollectionVecInput Accel { get; }
  
}