using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_AttractToControlPoint : IParticleFunctionForce {

  
  public ref Vector ComponentScale { get; }
  
  public IPerParticleFloatInput ForceAmount { get; }
  
  public ref float FalloffPower { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public IPerParticleFloatInput ForceAmountMin { get; }
  
  public ref bool ApplyMinForce { get; }
}