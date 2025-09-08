using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_TimeVaryingForce : IParticleFunctionForce {

  public ref float StartLerpTime { get; }
  
  public ref Vector StartingForce { get; }
  
  public ref float EndLerpTime { get; }
  
  public ref Vector EndingForce { get; }
  
}