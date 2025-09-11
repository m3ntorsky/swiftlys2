using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ParentVortices : IParticleFunctionForce {

  
  public ref float ForceScale { get; }
  
  public ref Vector TwistAxis { get; }
  
  public ref bool FlipBasedOnYaw { get; }
}