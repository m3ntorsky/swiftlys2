using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderTreeShake : IParticleFunctionRenderer {

  
  public ref float PeakStrength { get; }
  
  public IParticleAttributeIndex_t PeakStrengthFieldOverride { get; }
  
  public ref float Radius { get; }
  
  public IParticleAttributeIndex_t RadiusFieldOverride { get; }
  
  public ref float ShakeDuration { get; }
  
  public ref float TransitionTime { get; }
  
  public ref float TwistAmount { get; }
  
  public ref float RadialAmount { get; }
  
  public ref float ControlPointOrientationAmount { get; }
  
  public ref int ControlPointForLinearDirection { get; }
}