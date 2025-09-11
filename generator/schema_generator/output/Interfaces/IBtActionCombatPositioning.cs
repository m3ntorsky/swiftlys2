using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBtActionCombatPositioning : IBtNode {

  
  public ref CUtlString SensorInputKey { get; }
  
  public ref CUtlString IsAttackingKey { get; }
  
  public ICountdownTimer ActionTimer { get; }
  
  public ref bool Crouching { get; }
}