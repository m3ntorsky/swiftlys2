using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsProp : IBreakableProp {

  public IEntityIOOutput MotionEnabled { get; }
  
  public IEntityIOOutput OnAwakened { get; }
  
  public IEntityIOOutput OnAwake { get; }
  
  public IEntityIOOutput OnAsleep { get; }
  
  public IEntityIOOutput OnPlayerUse { get; }
  
  public IEntityIOOutput OnOutOfWorld { get; }
  
  public IEntityIOOutput OnPlayerPickup { get; }
  
  public ref bool ForceNavIgnore { get; }
  
  public ref bool NoNavmeshBlocker { get; }
  
  public ref bool ForceNpcExclude { get; }
  
  public ref float MassScale { get; }
  
  public ref float BuoyancyScale { get; }
  
  public ref int DamageType { get; }
  
  public ref int DamageToEnableMotion { get; }
  
  public ref float ForceToEnableMotion { get; }
  
  public ref bool ThrownByPlayer { get; }
  
  public ref bool DroppedByPlayer { get; }
  
  public ref bool TouchedByPlayer { get; }
  
  public ref bool FirstCollisionAfterLaunch { get; }
  
  public ref bool HasBeenAwakened { get; }
  
  public ref bool IsOverrideProp { get; }
  
  public IGameTime_t LastBurn { get; }
  
  public ref DynamicContinuousContactBehavior_t DynamicContinuousContactBehavior { get; }
  
  public IGameTime_t NextCheckDisableMotionContactsTime { get; }
  
  public ref int InitialGlowState { get; }
  
  public ref int GlowRange { get; }
  
  public ref int GlowRangeMin { get; }
  
  public ref Color GlowColor { get; }
  
  public ref bool ShouldAutoConvertBackFromDebris { get; }
  
  public ref bool MuteImpactEffects { get; }
  
  public ref bool AcceptDamageFromHeldObjects { get; }
  
  public ref bool EnableUseOutput { get; }
  
  public ref CPhysicsProp::CrateType_t CrateType { get; }
  
  public ISchemaFixedArray<CUtlSymbolLarge> StrItemClass { get; }
  
  public ISchemaFixedArray<int> ItemCount { get; }
  
  public ref bool RemovableForAmmoBalancing { get; }
  
  public ref bool Awake { get; }
  
  public ref bool AttachedToReferenceFrame { get; }
  
}