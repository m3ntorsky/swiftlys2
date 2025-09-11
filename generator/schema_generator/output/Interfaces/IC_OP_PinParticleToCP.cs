using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PinParticleToCP : IParticleFunctionOperator {

  
  public ref int ControlPointNumber { get; }
  
  public IParticleCollectionVecInput Offset { get; }
  
  public ref bool OffsetLocal { get; }
  
  public ref ParticleSelection_t ParticleSelection { get; }
  
  public IParticleCollectionFloatInput ParticleNumber { get; }
  
  public ref ParticlePinDistance_t PinBreakType { get; }
  
  public IParticleCollectionFloatInput BreakDistance { get; }
  
  public IParticleCollectionFloatInput BreakSpeed { get; }
  
  public IParticleCollectionFloatInput Age { get; }
  
  public ref int BreakControlPointNumber { get; }
  
  public ref int BreakControlPointNumber2 { get; }
  
  public IParticleCollectionFloatInput BreakValue { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
  public ref bool RetainInitialVelocity { get; }
}