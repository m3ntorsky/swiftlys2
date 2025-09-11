using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_ScreenSpacePositionOfTarget : IParticleFunctionInitializer {

  
  public IPerParticleVecInput TargetPosition { get; }
  
  public ref bool OututBehindness { get; }
  
  public IParticleAttributeIndex_t BehindFieldOutput { get; }
  
  public IParticleRemapFloatInput BehindOutputRemap { get; }
}