using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RotateVector : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref Vector RotAxisMin { get; }
  
  public ref Vector RotAxisMax { get; }
  
  public ref float RotRateMin { get; }
  
  public ref float RotRateMax { get; }
  
  public ref bool Normalize { get; }
  
  public IPerParticleFloatInput Scale { get; }
  
}