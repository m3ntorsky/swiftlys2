using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderVRHapticEvent : IParticleFunctionRenderer {

  public ref ParticleVRHandChoiceList_t Hand { get; }
  
  public ref int OutputHandCP { get; }
  
  public ref int OutputField { get; }
  
  public IPerParticleFloatInput Amplitude { get; }
  
}