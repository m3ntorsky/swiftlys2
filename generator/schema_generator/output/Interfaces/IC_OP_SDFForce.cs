using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SDFForce : IParticleFunctionForce {

  
  public ref float ForceScale { get; }
}