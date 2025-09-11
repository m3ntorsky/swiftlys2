using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ChladniWave : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleFloatInput InputMin { get; }
  
  public IPerParticleFloatInput InputMax { get; }
  
  public IPerParticleFloatInput OutputMin { get; }
  
  public IPerParticleFloatInput OutputMax { get; }
  
  public IPerParticleVecInput WaveLength { get; }
  
  public IPerParticleVecInput Harmonics { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref int LocalSpaceControlPoint { get; }
  
  public ref bool B3D { get; }
}