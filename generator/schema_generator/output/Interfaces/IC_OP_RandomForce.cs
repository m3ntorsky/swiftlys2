using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RandomForce : IParticleFunctionForce {

  public ref Vector MinForce { get; }
  
  public ref Vector MaxForce { get; }
  
}