using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseButton : IBaseToggle {

  
  public ref QAngle MoveEntitySpace { get; }
  
  public ref bool StayPushed { get; }
  
  public ref bool Rotating { get; }
  
  public Ilocksound_t Ls { get; }
  
  public ISchemaUntypedField UseSound { get; }
  
  public ISchemaUntypedField LockedSound { get; }
  
  public ISchemaUntypedField UnlockedSound { get; }
  
  public ISchemaUntypedField OverrideAnticipationName { get; }
  
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
  
  public ref CHandle<IEntityInstance> Constraint { get; }
  
  public ref CHandle<IEntityInstance> ConstraintParent { get; }
  
  public ref bool ForceNpcExclude { get; }
  
  public ISchemaUntypedField GlowEntity { get; }
  
  public ref CHandle<CBaseModelEntity> GlowEntity { get; }
  
  public ref bool Usable { get; }
  
  public ISchemaUntypedField DisplayText { get; }
}