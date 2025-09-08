using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CycleScalar : IParticleFunctionOperator {

  public IParticleAttributeIndex_t DestField { get; }
  
  public ref float StartValue { get; }
  
  public ref float EndValue { get; }
  
  public ref float CycleTime { get; }
  
  public ref bool DoNotRepeatCycle { get; }
  
  public ref bool SynchronizeParticles { get; }
  
  public ref int CPScale { get; }
  
  public ref int CPFieldMin { get; }
  
  public ref int CPFieldMax { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
}