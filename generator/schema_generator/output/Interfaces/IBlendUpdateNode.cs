using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBlendUpdateNode : IAnimUpdateNodeBase {

  public ref CUtlVector Children { get; }
  
  public ref CUtlVector<byte> SortedOrder { get; }
  
  public ref CUtlVector<float> TargetValues { get; }
  
  public ref AnimValueSource BlendValueSource { get; }
  
  public ref LinearRootMotionBlendMode_t LinearRootMotionBlendMode { get; }
  
  public IAnimParamHandle ParamIndex { get; }
  
  public IAnimInputDamping Damping { get; }
  
  public ref BlendKeyType BlendKeyType { get; }
  
  public ref bool LockBlendOnReset { get; }
  
  public ref bool SyncCycles { get; }
  
  public ref bool Loop { get; }
  
  public ref bool LockWhenWaning { get; }
  
  public ref bool IsAngle { get; }
  
}