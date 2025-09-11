using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayerInputAnimMotorUpdater : IAnimMotorUpdaterBase {

  
  public ref CUtlVector<float> SampleTimes { get; }
  
  public ref float SpringConstant { get; }
  
  public ref float AnticipationDistance { get; }
  
  public IAnimParamHandle AnticipationPosParam { get; }
  
  public IAnimParamHandle AnticipationHeadingParam { get; }
  
  public ref bool UseAcceleration { get; }
}