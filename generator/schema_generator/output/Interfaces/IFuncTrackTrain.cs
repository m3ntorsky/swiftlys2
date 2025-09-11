using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncTrackTrain : IBaseModelEntity {

  
  public ref CHandle<CPathTrack> Ppath { get; }
  
  public ref float Length { get; }
  
  public ref Vector PosPrev { get; }
  
  public ref QAngle Prev { get; }
  
  public ref Vector ControlMins { get; }
  
  public ref Vector ControlMaxs { get; }
  
  public ref Vector LastBlockPos { get; }
  
  public ref int LastBlockTick { get; }
  
  public ref float Volume { get; }
  
  public ref float Bank { get; }
  
  public ref float OldSpeed { get; }
  
  public ref float BlockDamage { get; }
  
  public ref float Height { get; }
  
  public ref float MaxSpeed { get; }
  
  public ref float Dir { get; }
  
  public ref CUtlSymbolLarge SoundMove { get; }
  
  public ref CUtlSymbolLarge SoundMovePing { get; }
  
  public ref CUtlSymbolLarge SoundStart { get; }
  
  public ref CUtlSymbolLarge SoundStop { get; }
  
  public ref CUtlSymbolLarge StrPathTarget { get; }
  
  public ref float MoveSoundMinDuration { get; }
  
  public ref float MoveSoundMaxDuration { get; }
  
  public IGameTime_t NextMoveSoundTime { get; }
  
  public ref float MoveSoundMinPitch { get; }
  
  public ref float MoveSoundMaxPitch { get; }
  
  public ref TrainOrientationType_t OrientationType { get; }
  
  public ref TrainVelocityType_t VelocityType { get; }
  
  public IEntityIOOutput OnStart { get; }
  
  public IEntityIOOutput OnNext { get; }
  
  public IEntityIOOutput OnArrivedAtDestinationNode { get; }
  
  public ref bool ManualSpeedChanges { get; }
  
  public ref float DesiredSpeed { get; }
  
  public IGameTime_t SpeedChangeTime { get; }
  
  public ref float AccelSpeed { get; }
  
  public ref float DecelSpeed { get; }
  
  public ref bool AccelToSpeed { get; }
  
  public IGameTime_t NextMPSoundTime { get; }
}