using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerHurt : IBaseTrigger {

  public ref float OriginalDamage { get; }
  
  public ref float Damage { get; }
  
  public ref float DamageCap { get; }
  
  public IGameTime_t LastDmgTime { get; }
  
  public ref float ForgivenessDelay { get; }
  
  public ref DamageTypes_t BitsDamageInflict { get; }
  
  public ref int DamageModel { get; }
  
  public ref bool NoDmgForce { get; }
  
  public ref Vector DamageForce { get; }
  
  public ref bool ThinkAlways { get; }
  
  public ref float HurtThinkPeriod { get; }
  
  public IEntityIOOutput OnHurt { get; }
  
  public IEntityIOOutput OnHurtPlayer { get; }
  
  public ref CUtlVector<CHandle<CBaseEntity>> HurtEntities { get; }
  
}