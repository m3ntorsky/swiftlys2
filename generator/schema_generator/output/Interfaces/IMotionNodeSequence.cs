using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionNodeSequence : IMotionNode {

  
// CUtlVector< TagSpan_t >
  public ref CUtlVector Tags { get; }
  
  public IHSequence Sequence { get; }
  
  public ref float PlaybackSpeed { get; }
}