using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ColorAdjustHSL : IParticleFunctionOperator {

  public IPerParticleFloatInput HueAdjust { get; }
  
  public IPerParticleFloatInput SaturationAdjust { get; }
  
  public IPerParticleFloatInput LightnessAdjust { get; }
  
}