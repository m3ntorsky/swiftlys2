using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointValueRemapper : IBaseEntity {

  public ref bool Disabled { get; }
  
  public ref bool UpdateOnClient { get; }
  
  public ref ValueRemapperInputType_t InputType { get; }
  
  public ref CUtlSymbolLarge RemapLineStartName { get; }
  
  public ref CUtlSymbolLarge RemapLineEndName { get; }
  
  public CHandle<IBaseEntity> RemapLineStart { get; }
  
  public CHandle<IBaseEntity> RemapLineEnd { get; }
  
  public ref float MaximumChangePerSecond { get; }
  
  public ref float DisengageDistance { get; }
  
  public ref float EngageDistance { get; }
  
  public ref bool RequiresUseKey { get; }
  
  public ref ValueRemapperOutputType_t OutputType { get; }
  
  public ref CUtlSymbolLarge OutputEntityName { get; }
  
  public ref CUtlSymbolLarge OutputEntity2Name { get; }
  
  public ref CUtlSymbolLarge OutputEntity3Name { get; }
  
  public ref CUtlSymbolLarge OutputEntity4Name { get; }
  
  public ref CUtlVector OutputEntities { get; }
  
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
  
  public CHandle<IBasePlayerPawn> UsingPlayer { get; }
  
  public ref float CustomOutputValue { get; }
  
  public ref CUtlSymbolLarge SoundEngage { get; }
  
  public ref CUtlSymbolLarge SoundDisengage { get; }
  
  public ref CUtlSymbolLarge SoundReachedValueZero { get; }
  
  public ref CUtlSymbolLarge SoundReachedValueOne { get; }
  
  public ref CUtlSymbolLarge SoundMovingLoop { get; }
  
  public ISchemaUntypedField Position { get; }
  
  public ISchemaUntypedField PositionDelta { get; }
  
  public IEntityIOOutput OnReachedValueZero { get; }
  
  public IEntityIOOutput OnReachedValueOne { get; }
  
  public IEntityIOOutput OnReachedValueCustom { get; }
  
  public IEntityIOOutput OnEngage { get; }
  
  public IEntityIOOutput OnDisengage { get; }
  
}