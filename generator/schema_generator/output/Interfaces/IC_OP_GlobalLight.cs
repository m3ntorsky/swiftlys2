using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_GlobalLight : IParticleFunctionOperator {

  
  public ref float Scale { get; }
  
  public ref bool ClampLowerRange { get; }
  
  public ref bool ClampUpperRange { get; }
}