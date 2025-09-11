using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITargetSelectorUpdateNode : IAnimUpdateNodeBase {

  
  public ref TargetSelectorAngleMode_t AngleMode { get; }
  
// CUtlVector< CAnimUpdateNodeRef >
  public ref CUtlVector Children { get; }
  
  public IAnimParamHandle TargetPosition { get; }
  
  public IAnimParamHandle TargetFacePositionParameter { get; }
  
  public IAnimParamHandle MoveHeadingParameter { get; }
  
  public IAnimParamHandle DesiredMoveHeadingParameter { get; }
  
  public ref bool TargetPositionIsWorldSpace { get; }
  
  public ref bool TargetFacePositionIsWorldSpace { get; }
  
  public ref bool EnablePhaseMatching { get; }
  
  public ref float PhaseMatchingMaxRootMotionSkip { get; }
}