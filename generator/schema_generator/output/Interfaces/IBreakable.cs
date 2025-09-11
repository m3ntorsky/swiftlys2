using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBreakable : IBaseModelEntity {

  
  public IPropDataComponent CPropDataComponent { get; }
  
  public ref Materials Material { get; }
  
  public ref CHandle<CBaseEntity> Breaker { get; }
  
  public ref Explosions Explosion { get; }
  
  public ref CUtlSymbolLarge SpawnObject { get; }
  
  public ref float PressureDelay { get; }
  
  public ref int MinHealthDmg { get; }
  
  public ref CUtlSymbolLarge PropData { get; }
  
  public ref float ImpactEnergyScale { get; }
  
  public ref EOverrideBlockLOS_t OverrideBlockLOS { get; }
  
  public IEntityIOOutput OnBreak { get; }
  
  public ISchemaUntypedField OnHealthChanged { get; }
  
  public ref PerformanceMode_t PerformanceMode { get; }
  
  public ref CHandle<CBasePlayerPawn> PhysicsAttacker { get; }
  
  public IGameTime_t LastPhysicsInfluenceTime { get; }
}