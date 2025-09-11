using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITargetWarpUpdateNode : IUnaryUpdateNode {

  
  public ref TargetWarpAngleMode_t AngleMode { get; }
  
  public IAnimParamHandle TargetPositionParameter { get; }
  
  public IAnimParamHandle TargetUpVectorParameter { get; }
  
  public IAnimParamHandle TargetFacePositionParameter { get; }
  
  public IAnimParamHandle MoveHeadingParameter { get; }
  
  public IAnimParamHandle DesiredMoveHeadingParameter { get; }
  
  public ref TargetWarpCorrectionMethod CorrectionMethod { get; }
  
  public ref TargetWarpTimingMethod TargetWarpTimingMethod { get; }
  
  public ref bool TargetFacePositionIsWorldSpace { get; }
  
  public ref bool TargetPositionIsWorldSpace { get; }
  
  public ref bool OnlyWarpWhenTagIsFound { get; }
  
  public ref bool WarpOrientationDuringTranslation { get; }
  
  public ref bool WarpAroundCenter { get; }
  
  public ref float MaxAngle { get; }
}