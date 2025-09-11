using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ConstrainDistanceToPath : IParticleFunctionConstraint {

  
  public ref float MinDistance { get; }
  
  public ref float MaxDistance0 { get; }
  
  public ref float MaxDistanceMid { get; }
  
  public ref float MaxDistance1 { get; }
  
  public IPathParameters PathParameters { get; }
  
  public ref float TravelTime { get; }
  
  public IParticleAttributeIndex_t FieldScale { get; }
  
  public IParticleAttributeIndex_t ManualTField { get; }
}