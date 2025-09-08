using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderSound : IParticleFunctionRenderer {

  public ref float DurationScale { get; }
  
  public ref float SndLvlScale { get; }
  
  public ref float PitchScale { get; }
  
  public ref float VolumeScale { get; }
  
  public IParticleAttributeIndex_t SndLvlField { get; }
  
  public IParticleAttributeIndex_t DurationField { get; }
  
  public IParticleAttributeIndex_t PitchField { get; }
  
  public IParticleAttributeIndex_t VolumeField { get; }
  
  public ref int Channel { get; }
  
  public ref int CPReference { get; }
  
  public ISchemaFixedString SoundName { get; }
  
  public ref bool SuppressStopSoundEvent { get; }
  
}