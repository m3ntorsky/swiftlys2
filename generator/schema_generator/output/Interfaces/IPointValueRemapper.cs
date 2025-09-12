using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointValueRemapper : IBaseEntity {

  
  public ref bool Disabled { get; }
  
  public ref bool UpdateOnClient { get; }
  
  public ref ValueRemapperInputType_t InputType { get; }
  
  public ISchemaUntypedField RemapLineStartName { get; }
  
  public ISchemaUntypedField RemapLineEndName { get; }
  
  public ref CHandle<CBaseEntity> RemapLineStart { get; }
  
  public ref CHandle<CBaseEntity> RemapLineEnd { get; }
  
  public ref float MaximumChangePerSecond { get; }
  
  public ref float DisengageDistance { get; }
  
  public ref float EngageDistance { get; }
  
  public ref bool RequiresUseKey { get; }
  
  public ref ValueRemapperOutputType_t OutputType { get; }
  
  public ISchemaUntypedField OutputEntityName { get; }
  
  public ISchemaUntypedField OutputEntity2Name { get; }
  
  public ISchemaUntypedField OutputEntity3Name { get; }
  
  public ISchemaUntypedField OutputEntity4Name { get; }
  
  public ref CUtlVector<CHandle<CBaseEntity>> OutputEntities { get; }
  
  public ref ValueRemapperHapticsType_t HapticsType { get; }
  
  public ref ValueRemapperMomentumType_t MomentumType { get; }
  
  public ref float MomentumModifier { get; }
  
  public ref float SnapValue { get; }
  
  public ref float CurrentMomentum { get; }
  
  public ref ValueRemapperRatchetType_t RatchetType { get; }
  
  public ref float RatchetOffset { get; }
  
  public ref float InputOffset { get; }
  
  public ref bool Engaged { get; }
  
  public ref bool FirstUpdate { get; }
  
  public ref float PreviousValue { get; }
  
  public IGameTime_t PreviousUpdateTickTime { get; }
  
  public ref Vector PreviousTestPoint { get; }
  
  public ref CHandle<CBasePlayerPawn> UsingPlayer { get; }
  
  public ref float CustomOutputValue { get; }
  
  public ISchemaUntypedField SoundEngage { get; }
  
  public ISchemaUntypedField SoundDisengage { get; }
  
  public ISchemaUntypedField SoundReachedValueZero { get; }
  
  public ISchemaUntypedField SoundReachedValueOne { get; }
  
  public ISchemaUntypedField SoundMovingLoop { get; }
  
  public ISchemaUntypedField Position { get; }
  
  public ISchemaUntypedField PositionDelta { get; }
  
  public IEntityIOOutput OnReachedValueZero { get; }
  
  public IEntityIOOutput OnReachedValueOne { get; }
  
  public IEntityIOOutput OnReachedValueCustom { get; }
  
  public IEntityIOOutput OnEngage { get; }
  
  public IEntityIOOutput OnDisengage { get; }
}