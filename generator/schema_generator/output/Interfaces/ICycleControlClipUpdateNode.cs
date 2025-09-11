using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICycleControlClipUpdateNode : ILeafUpdateNode {

  
// CUtlVector< TagSpan_t >
  public ref CUtlVector Tags { get; }
  
  public IHSequence Sequence { get; }
  
  public ref float Duration { get; }
  
  public ref AnimValueSource ValueSource { get; }
  
  public IAnimParamHandle ParamIndex { get; }
  
  public ref bool LockWhenWaning { get; }
}