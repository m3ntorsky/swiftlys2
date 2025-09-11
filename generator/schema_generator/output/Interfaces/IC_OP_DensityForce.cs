using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DensityForce : IParticleFunctionForce {

  
  public ref float RadiusScale { get; }
  
  public ref float ForceScale { get; }
  
  public ref float TargetDensity { get; }
}