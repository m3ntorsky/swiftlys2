using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DampenToCP : IParticleFunctionOperator {

  
  public ref int ControlPointNumber { get; }
  
  public ref float Range { get; }
  
  public ref float Scale { get; }
}