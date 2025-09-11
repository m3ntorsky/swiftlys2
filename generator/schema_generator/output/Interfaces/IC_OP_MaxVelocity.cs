using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MaxVelocity : IParticleFunctionOperator {

  
  public ref float MaxVelocity { get; }
  
  public ref float MinVelocity { get; }
  
  public ref int OverrideCP { get; }
  
  public ref int OverrideCPField { get; }
}