using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LagCompensation : IParticleFunctionOperator {

  
  public ref int DesiredVelocityCP { get; }
  
  public ref int LatencyCP { get; }
  
  public ref int LatencyCPField { get; }
  
  public ref int DesiredVelocityCPField { get; }
}