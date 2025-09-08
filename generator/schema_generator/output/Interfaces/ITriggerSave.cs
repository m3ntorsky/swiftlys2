using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerSave : IBaseTrigger {

  public ref bool ForceNewLevelUnit { get; }
  
  public ref float DangerousTimer { get; }
  
  public ref int MinHitPoints { get; }
  
}