using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerGameEvent : IBaseTrigger {

  public ref CUtlString StrStartTouchEventName { get; }
  
  public ref CUtlString StrEndTouchEventName { get; }
  
  public ref CUtlString StrTriggerID { get; }
  
}