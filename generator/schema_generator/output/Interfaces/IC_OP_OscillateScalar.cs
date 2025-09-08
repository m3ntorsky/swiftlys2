using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_OscillateScalar : IParticleFunctionOperator {

  public ref float RateMin { get; }
  
  public ref float RateMax { get; }
  
  public ref float FrequencyMin { get; }
  
  public ref float FrequencyMax { get; }
  
  public IParticleAttributeIndex_t Field { get; }
  
  public ref bool Proportional { get; }
  
  public ref bool ProportionalOp { get; }
  
  public ref float StartTime_min { get; }
  
  public ref float StartTime_max { get; }
  
  public ref float EndTime_min { get; }
  
  public ref float EndTime_max { get; }
  
  public ref float OscMult { get; }
  
  public ref float OscAdd { get; }
  
}