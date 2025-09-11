using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CPVelocityForce : IParticleFunctionForce {

  
  public ref int ControlPointNumber { get; }
  
  public IPerParticleFloatInput Scale { get; }
}