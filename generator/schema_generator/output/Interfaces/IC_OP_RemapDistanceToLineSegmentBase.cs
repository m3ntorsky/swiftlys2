using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapDistanceToLineSegmentBase : IParticleFunctionOperator {

  public ref int CP0 { get; }
  
  public ref int CP1 { get; }
  
  public ref float MinInputValue { get; }
  
  public ref float MaxInputValue { get; }
  
  public ref bool InfiniteLine { get; }
  
}