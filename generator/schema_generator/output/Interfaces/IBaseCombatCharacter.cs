using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseCombatCharacter : IBaseFlex {

  public ref bool ForceServerRagdoll { get; }
  
  public ref CUtlVector<CHandle<CEconWearable>> MyWearables { get; }
  
  public ref float ImpactEnergyScale { get; }
  
  public ref int MinVehicleDamageToTempRagdoll { get; }
  
  public ref bool ApplyStressDamage { get; }
  
  public ref bool DeathEventsDispatched { get; }
  
  public ref CUtlVector VecRelationships { get; }
  
  public ref CUtlSymbolLarge StrRelationships { get; }
  
  public ref Hull_t Hull { get; }
  
  public ref uint NavHullIdx { get; }
  
  public IMovementStatsProperty MovementStats { get; }
  
}