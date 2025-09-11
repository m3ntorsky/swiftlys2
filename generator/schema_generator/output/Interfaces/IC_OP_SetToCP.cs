using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetToCP : IParticleFunctionOperator {

  
  public ref int ControlPointNumber { get; }
  
  public ref Vector Offset { get; }
  
  public ref bool OffsetLocal { get; }
}