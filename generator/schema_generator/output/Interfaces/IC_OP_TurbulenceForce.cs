using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_TurbulenceForce : IParticleFunctionForce {

  
  public ref float NoiseCoordScale0 { get; }
  
  public ref float NoiseCoordScale1 { get; }
  
  public ref float NoiseCoordScale2 { get; }
  
  public ref float NoiseCoordScale3 { get; }
  
  public ref Vector NoiseAmount0 { get; }
  
  public ref Vector NoiseAmount1 { get; }
  
  public ref Vector NoiseAmount2 { get; }
  
  public ref Vector NoiseAmount3 { get; }
}