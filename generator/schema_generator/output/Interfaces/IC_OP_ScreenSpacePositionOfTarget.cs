using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ScreenSpacePositionOfTarget : IParticleFunctionOperator {

  
  public IPerParticleVecInput TargetPosition { get; }
  
  public ref bool OututBehindness { get; }
  
  public IParticleAttributeIndex_t BehindFieldOutput { get; }
  
  public IParticleRemapFloatInput BehindOutputRemap { get; }
  
  public ref ParticleSetMethod_t BehindSetMethod { get; }
}