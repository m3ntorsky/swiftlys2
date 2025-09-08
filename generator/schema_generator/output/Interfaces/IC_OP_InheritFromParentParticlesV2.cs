using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_InheritFromParentParticlesV2 : IParticleFunctionOperator {

  public IPerParticleFloatInput Scale { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleFloatInput Increment { get; }
  
  public ref bool RandomDistribution { get; }
  
  public ref bool Reverse { get; }
  
  public ref MissingParentInheritBehavior_t MissingParentBehavior { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
}