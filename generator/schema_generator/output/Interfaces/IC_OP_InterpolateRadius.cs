using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_InterpolateRadius : IParticleFunctionOperator {

  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
  public ref float StartScale { get; }
  
  public ref float EndScale { get; }
  
  public ref bool EaseInAndOut { get; }
  
  public ref float Bias { get; }
  
}