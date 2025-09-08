using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBreakableProp : IBaseProp {

  public IPropDataComponent CPropDataComponent { get; }
  
  public IEntityIOOutput OnStartDeath { get; }
  
  public IEntityIOOutput OnBreak { get; }
  
  public ISchemaUntypedField OnHealthChanged { get; }
  
  public IEntityIOOutput OnTakeDamage { get; }
  
  public ref float ImpactEnergyScale { get; }
  
  public ref int MinHealthDmg { get; }
  
  public ref QAngle PreferredCarryAngles { get; }
  
  public ref float PressureDelay { get; }
  
  public ref float DefBurstScale { get; }
  
  public ref Vector DefBurstOffset { get; }
  
  public CHandle<IBaseEntity> Breaker { get; }
  
  public ref PerformanceMode_t PerformanceMode { get; }
  
  public IGameTime_t PreventDamageBeforeTime { get; }
  
  public ref BreakableContentsType_t BreakableContentsType { get; }
  
  public ref CUtlString StrBreakableContentsPropGroupOverride { get; }
  
  public ref CUtlString StrBreakableContentsParticleOverride { get; }
  
  public ref bool HasBreakPiecesOrCommands { get; }
  
  public ref float ExplodeDamage { get; }
  
  public ref float ExplodeRadius { get; }
  
  public ref float ExplosionDelay { get; }
  
  public ref CUtlSymbolLarge ExplosionBuildupSound { get; }
  
  public ref CUtlSymbolLarge ExplosionCustomEffect { get; }
  
  public ref CUtlSymbolLarge ExplosionCustomSound { get; }
  
  public ref CUtlSymbolLarge ExplosionModifier { get; }
  
  public CHandle<IBasePlayerPawn> PhysicsAttacker { get; }
  
  public IGameTime_t LastPhysicsInfluenceTime { get; }
  
  public ref float DefaultFadeScale { get; }
  
  public CHandle<IBaseEntity> LastAttacker { get; }
  
  public ref CUtlSymbolLarge PuntSound { get; }
  
  public ref bool UsePuntSound { get; }
  
  public ref bool OriginalBlockLOS { get; }
  
}