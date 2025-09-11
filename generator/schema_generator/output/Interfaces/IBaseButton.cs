using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseButton : IBaseToggle {

  
  public ref QAngle MoveEntitySpace { get; }
  
  public ref bool StayPushed { get; }
  
  public ref bool Rotating { get; }
  
  public Ilocksound_t Ls { get; }
  
  public ref CUtlSymbolLarge UseSound { get; }
  
  public ref CUtlSymbolLarge LockedSound { get; }
  
  public ref CUtlSymbolLarge UnlockedSound { get; }
  
  public ref CUtlSymbolLarge OverrideAnticipationName { get; }
  
  public ref bool Locked { get; }
  
  public ref bool Disabled { get; }
  
  public IGameTime_t UseLockedTime { get; }
  
  public ref bool SolidBsp { get; }
  
  public IEntityIOOutput OnDamaged { get; }
  
  public IEntityIOOutput OnPressed { get; }
  
  public IEntityIOOutput OnUseLocked { get; }
  
  public IEntityIOOutput OnIn { get; }
  
  public IEntityIOOutput OnOut { get; }
  
  public ref int State { get; }
  
  public ref CEntityHandle Constraint { get; }
  
  public ref CEntityHandle ConstraintParent { get; }
  
  public ref bool ForceNpcExclude { get; }
  
  public ref CUtlSymbolLarge GlowEntity { get; }
  
  public ref CHandle<CBaseModelEntity> GlowEntity { get; }
  
  public ref bool Usable { get; }
  
  public ref CUtlSymbolLarge DisplayText { get; }
}