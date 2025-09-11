using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CPOffsetToPercentageBetweenCPs : IParticleFunctionOperator {

  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float InputBias { get; }
  
  public ref int StartCP { get; }
  
  public ref int EndCP { get; }
  
  public ref int OffsetCP { get; }
  
  public ref int OuputCP { get; }
  
  public ref int InputCP { get; }
  
  public ref bool RadialCheck { get; }
  
  public ref bool ScaleOffset { get; }
  
  public ref Vector Offset { get; }
}