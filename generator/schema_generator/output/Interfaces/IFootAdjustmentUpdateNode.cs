using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootAdjustmentUpdateNode : IUnaryUpdateNode {

  
// CUtlVector< HSequence >
  public ref CUtlVector Clips { get; }
  
  public IPoseHandle BasePoseCacheHandle { get; }
  
  public IAnimParamHandle FacingTarget { get; }
  
  public ref float TurnTimeMin { get; }
  
  public ref float TurnTimeMax { get; }
  
  public ref float StepHeightMax { get; }
  
  public ref float StepHeightMaxAngle { get; }
  
  public ref bool ResetChild { get; }
  
  public ref bool AnimationDriven { get; }
}