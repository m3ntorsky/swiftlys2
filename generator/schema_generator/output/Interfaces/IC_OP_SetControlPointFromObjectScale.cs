using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointFromObjectScale : IParticleFunctionPreEmission {

  
  public ref int CPInput { get; }
  
  public ref int CPOutput { get; }
}