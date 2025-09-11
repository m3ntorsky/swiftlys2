using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseFlex : IBaseAnimGraph {

  
  public ref CUtlVector<float> FlexWeight { get; }
  
  public ref Vector LookTargetPosition { get; }
  
  public ref bool Blinktoggle { get; }
  
  public IGameTime_t AllowResponsesEndTime { get; }
  
  public IGameTime_t LastFlexAnimationTime { get; }
  
  public ISceneEventId_t NextSceneEventId { get; }
  
  public ref bool UpdateLayerPriorities { get; }
}