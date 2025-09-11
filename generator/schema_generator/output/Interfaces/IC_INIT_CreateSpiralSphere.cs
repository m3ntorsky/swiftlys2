using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateSpiralSphere : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public ref int OverrideCP { get; }
  
  public ref int Density { get; }
  
  public ref float InitialRadius { get; }
  
  public ref float InitialSpeedMin { get; }
  
  public ref float InitialSpeedMax { get; }
  
  public ref bool UseParticleCount { get; }
}