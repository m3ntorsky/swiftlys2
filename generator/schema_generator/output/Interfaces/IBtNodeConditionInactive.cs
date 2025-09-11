using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBtNodeConditionInactive : IBtNodeCondition {

  
  public ref float RoundStartThresholdSeconds { get; }
  
  public ref float SensorInactivityThresholdSeconds { get; }
  
  public ICountdownTimer SensorInactivityTimer { get; }
}