using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_OscillateVector : IParticleFunctionOperator {

  
  public ref Vector RateMin { get; }
  
  public ref Vector RateMax { get; }
  
  public ref Vector FrequencyMin { get; }
  
  public ref Vector FrequencyMax { get; }
  
  public IParticleAttributeIndex_t Field { get; }
  
  public ref bool Proportional { get; }
  
  public ref bool ProportionalOp { get; }
  
  public ref bool Offset { get; }
  
  public ref float StartTime_min { get; }
  
  public ref float StartTime_max { get; }
  
  public ref float EndTime_min { get; }
  
  public ref float EndTime_max { get; }
  
  public IPerParticleFloatInput OscMult { get; }
  
  public IPerParticleFloatInput OscAdd { get; }
  
  public IPerParticleFloatInput RateScale { get; }
}