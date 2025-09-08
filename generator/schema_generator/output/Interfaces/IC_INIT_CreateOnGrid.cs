using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateOnGrid : IParticleFunctionInitializer {

  public IParticleCollectionFloatInput XCount { get; }
  
  public IParticleCollectionFloatInput YCount { get; }
  
  public IParticleCollectionFloatInput ZCount { get; }
  
  public IParticleCollectionFloatInput XSpacing { get; }
  
  public IParticleCollectionFloatInput YSpacing { get; }
  
  public IParticleCollectionFloatInput ZSpacing { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool LocalSpace { get; }
  
  public ref bool Center { get; }
  
  public ref bool Hollow { get; }
  
}