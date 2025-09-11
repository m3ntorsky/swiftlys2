using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_Decay : IParticleFunctionOperator {

  
  public ref bool RopeDecay { get; }
  
  public ref bool ForcePreserveParticleOrder { get; }
}