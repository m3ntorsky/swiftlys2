using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateInEpitrochoid : IParticleFunctionInitializer {

  public ref int Component1 { get; }
  
  public ref int Component2 { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public IPerParticleFloatInput ParticleDensity { get; }
  
  public IPerParticleFloatInput Offset { get; }
  
  public IPerParticleFloatInput Radius1 { get; }
  
  public IPerParticleFloatInput Radius2 { get; }
  
  public ref bool UseCount { get; }
  
  public ref bool UseLocalCoords { get; }
  
  public ref bool OffsetExistingPos { get; }
  
}