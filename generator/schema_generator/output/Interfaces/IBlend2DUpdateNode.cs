using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBlend2DUpdateNode : IAnimUpdateNodeBase {

  public ref CUtlVector Items { get; }
  
  public ref CUtlVector Tags { get; }
  
  public IParamSpanUpdater ParamSpans { get; }
  
  public ref CUtlVector<int> NodeItemIndices { get; }
  
  public IAnimInputDamping Damping { get; }
  
  public ref AnimValueSource BlendSourceX { get; }
  
  public IAnimParamHandle ParamX { get; }
  
  public ref AnimValueSource BlendSourceY { get; }
  
  public IAnimParamHandle ParamY { get; }
  
  public ref Blend2DMode BlendMode { get; }
  
  public ref float PlaybackSpeed { get; }
  
  public ref bool Loop { get; }
  
  public ref bool LockBlendOnReset { get; }
  
  public ref bool LockWhenWaning { get; }
  
  public ref bool AnimEventsAndTagsOnMostWeightedOnly { get; }
  
}