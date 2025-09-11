using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ConstrainDistance : IParticleFunctionConstraint {

  
  public IParticleCollectionFloatInput MinDistance { get; }
  
  public IParticleCollectionFloatInput MaxDistance { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref Vector CenterOffset { get; }
  
  public ref bool GlobalCenter { get; }
}