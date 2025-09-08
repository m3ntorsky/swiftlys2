using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IOrientationWarpUpdateNode : IUnaryUpdateNode {

  public ref OrientationWarpMode_t Mode { get; }
  
  public IAnimParamHandle TargetParam { get; }
  
  public IAnimParamHandle TargetPositionParam { get; }
  
  public IAnimParamHandle FallbackTargetPositionParam { get; }
  
  public ref OrientationWarpTargetOffsetMode_t TargetOffsetMode { get; }
  
  public ref float TargetOffset { get; }
  
  public IAnimParamHandle TargetOffsetParam { get; }
  
  public IAnimInputDamping Damping { get; }
  
  public ref OrientationWarpRootMotionSource_t RootMotionSource { get; }
  
  public ref float MaxRootMotionScale { get; }
  
  public ref bool EnablePreferredRotationDirection { get; }
  
  public ref AnimValueSource PreferredRotationDirection { get; }
  
  public ref float PreferredRotationThreshold { get; }
  
}