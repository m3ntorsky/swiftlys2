using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LockPoints : IParticleFunctionOperator {

  
  public ref int MinCol { get; }
  
  public ref int MaxCol { get; }
  
  public ref int MinRow { get; }
  
  public ref int MaxRow { get; }
  
  public ref int ControlPoint { get; }
  
  public ref float BlendValue { get; }
}