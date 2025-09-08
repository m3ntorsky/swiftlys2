using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISequenceUpdateNode : ISequenceUpdateNodeBase {

  public IHSequence Sequence { get; }
  
  public ref float Duration { get; }
  
  public IParamSpanUpdater ParamSpans { get; }
  
  public ref CUtlVector Tags { get; }
  
}