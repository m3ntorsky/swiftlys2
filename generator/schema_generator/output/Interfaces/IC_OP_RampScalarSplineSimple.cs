using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RampScalarSplineSimple : IParticleFunctionOperator {

  
  public ref float Rate { get; }
  
  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
  public IParticleAttributeIndex_t Field { get; }
  
  public ref bool EaseOut { get; }
}