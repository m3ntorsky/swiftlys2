using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ConstrainLineLength : IParticleFunctionConstraint {

  
  public ref float MinDistance { get; }
  
  public ref float MaxDistance { get; }
}