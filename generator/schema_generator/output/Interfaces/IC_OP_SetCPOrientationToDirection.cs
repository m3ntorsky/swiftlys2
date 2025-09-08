using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetCPOrientationToDirection : IParticleFunctionOperator {

  public ref int InputControlPoint { get; }
  
  public ref int OutputControlPoint { get; }
  
}