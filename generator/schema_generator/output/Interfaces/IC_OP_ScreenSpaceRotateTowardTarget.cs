using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ScreenSpaceRotateTowardTarget : IParticleFunctionOperator {

  
  public IPerParticleVecInput TargetPosition { get; }
  
  public IParticleRemapFloatInput OutputRemap { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public IPerParticleFloatInput ScreenEdgeAlignmentDistance { get; }
}