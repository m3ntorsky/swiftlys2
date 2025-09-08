using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC4 : ICSWeaponBase {

  public ref Vector LastValidPlayerHeldPosition { get; }
  
  public ref Vector LastValidDroppedPosition { get; }
  
  public ref bool DoValidDroppedPositionCheck { get; }
  
  public ref bool StartedArming { get; }
  
  public IGameTime_t ArmedTime { get; }
  
  public ref bool BombPlacedAnimation { get; }
  
  public ref bool IsPlantingViaUse { get; }
  
  public IEntitySpottedState_t EntitySpottedState { get; }
  
  public ref int SpotRules { get; }
  
  public ISchemaFixedArray<bool> PlayedArmingBeeps { get; }
  
  public ref bool BombPlanted { get; }
  
}