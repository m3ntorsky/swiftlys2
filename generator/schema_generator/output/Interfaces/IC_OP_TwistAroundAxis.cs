using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_TwistAroundAxis : IParticleFunctionForce {

  public ref float ForceAmount { get; }
  
  public ref Vector TwistAxis { get; }
  
  public ref bool LocalSpace { get; }
  
  public ref int ControlPointNumber { get; }
  
}