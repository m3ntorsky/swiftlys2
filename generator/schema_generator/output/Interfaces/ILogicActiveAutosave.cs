using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicActiveAutosave : ILogicAutosave {

  public ref int TriggerHitPoints { get; }
  
  public ref float TimeToTrigger { get; }
  
  public IGameTime_t StartTime { get; }
  
  public ref float DangerousTime { get; }
  
}