using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDampedPathAnimMotorUpdater : IPathAnimMotorUpdaterBase {

  public ref float AnticipationTime { get; }
  
  public ref float MinSpeedScale { get; }
  
  public IAnimParamHandle AnticipationPosParam { get; }
  
  public IAnimParamHandle AnticipationHeadingParam { get; }
  
  public ref float SpringConstant { get; }
  
  public ref float MinSpringTension { get; }
  
  public ref float MaxSpringTension { get; }
  
}