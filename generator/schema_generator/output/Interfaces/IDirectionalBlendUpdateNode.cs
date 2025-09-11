using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDirectionalBlendUpdateNode : ILeafUpdateNode {

  
  public IHSequence Sequences { get; }
  
  public IAnimInputDamping Damping { get; }
  
  public ref AnimValueSource BlendValueSource { get; }
  
  public IAnimParamHandle ParamIndex { get; }
  
  public ref float PlaybackSpeed { get; }
  
  public ref float Duration { get; }
  
  public ref bool Loop { get; }
  
  public ref bool LockBlendOnReset { get; }
}