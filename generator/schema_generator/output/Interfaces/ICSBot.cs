using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSBot : IBot {

  
  public ref Vector EyePosition { get; }
  
  public ISchemaFixedString Name { get; }
  
  public ref float CombatRange { get; }
  
  public ref bool IsRogue { get; }
  
  public ICountdownTimer RogueTimer { get; }
  
  public ref bool DiedLastRound { get; }
  
  public ref float SafeTime { get; }
  
  public ref bool WasSafe { get; }
  
  public ref bool BlindFire { get; }
  
  public ICountdownTimer SurpriseTimer { get; }
  
  public ref bool AllowActive { get; }
  
  public ref bool IsFollowing { get; }
  
  public ref CHandle<CCSPlayerPawn> Leader { get; }
  
  public ref float FollowTimestamp { get; }
  
  public ref float AllowAutoFollowTime { get; }
  
  public ICountdownTimer HurryTimer { get; }
  
  public ICountdownTimer AlertTimer { get; }
  
  public ICountdownTimer SneakTimer { get; }
  
  public ICountdownTimer PanicTimer { get; }
  
  public ref float StateTimestamp { get; }
  
  public ref bool IsAttacking { get; }
  
  public ref bool IsOpeningDoor { get; }
  
  public ref CHandle<CBaseEntity> TaskEntity { get; }
  
  public ref Vector GoalPosition { get; }
  
  public ref CHandle<CBaseEntity> GoalEntity { get; }
  
  public ref CHandle<CBaseEntity> Avoid { get; }
  
  public ref float AvoidTimestamp { get; }
  
  public ref bool IsStopping { get; }
  
  public ref bool HasVisitedEnemySpawn { get; }
  
  public IIntervalTimer StillTimer { get; }
  
  public ref bool EyeAnglesUnderPathFinderControl { get; }
  
  public ref int PathIndex { get; }
  
  public IGameTime_t AreaEnteredTimestamp { get; }
  
  public ICountdownTimer RepathTimer { get; }
  
  public ICountdownTimer AvoidFriendTimer { get; }
  
  public ref bool IsFriendInTheWay { get; }
  
  public ICountdownTimer PoliteTimer { get; }
  
  public ref bool IsWaitingBehindFriend { get; }
  
  public ref float PathLadderEnd { get; }
  
  public ICountdownTimer MustRunTimer { get; }
  
  public ICountdownTimer WaitTimer { get; }
  
  public ICountdownTimer UpdateTravelDistanceTimer { get; }
  
  public ISchemaFixedArray<float> PlayerTravelDistance { get; }
  
  public ref byte TravelDistancePhase { get; }
  
  public ref byte HostageEscortCount { get; }
  
  public ref float HostageEscortCountTimestamp { get; }
  
  public ref int DesiredTeam { get; }
  
  public ref bool HasJoined { get; }
  
  public ref bool IsWaitingForHostage { get; }
  
  public ICountdownTimer InhibitWaitingForHostageTimer { get; }
  
  public ICountdownTimer WaitForHostageTimer { get; }
  
  public ref Vector NoisePosition { get; }
  
  public ref float NoiseTravelDistance { get; }
  
  public ref float NoiseTimestamp { get; }
  
  public ICSPlayerPawn NoiseSource { get; }
  
  public ICountdownTimer NoiseBendTimer { get; }
  
  public ref Vector BentNoisePosition { get; }
  
  public ref bool BendNoisePositionValid { get; }
  
  public ref float LookAroundStateTimestamp { get; }
  
  public ref float LookAheadAngle { get; }
  
  public ref float ForwardAngle { get; }
  
  public ref float InhibitLookAroundTimestamp { get; }
  
  public ref Vector LookAtSpot { get; }
  
  public ref float LookAtSpotDuration { get; }
  
  public ref float LookAtSpotTimestamp { get; }
  
  public ref float LookAtSpotAngleTolerance { get; }
  
  public ref bool LookAtSpotClearIfClose { get; }
  
  public ref bool LookAtSpotAttack { get; }
  
  public ref CString LookAtDesc { get; }
  
  public ref float PeripheralTimestamp { get; }
  
  public ref byte ApproachPointCount { get; }
  
  public ref Vector ApproachPointViewPosition { get; }
  
  public IIntervalTimer ViewSteadyTimer { get; }
  
  public ICountdownTimer TossGrenadeTimer { get; }
  
  public ICountdownTimer IsAvoidingGrenade { get; }
  
  public ref float SpotCheckTimestamp { get; }
  
  public ref int CheckedHidingSpotCount { get; }
  
  public ref float LookPitch { get; }
  
  public ref float LookPitchVel { get; }
  
  public ref float LookYaw { get; }
  
  public ref float LookYawVel { get; }
  
  public ref Vector TargetSpot { get; }
  
  public ref Vector TargetSpotVelocity { get; }
  
  public ref Vector TargetSpotPredicted { get; }
  
  public ref QAngle AimError { get; }
  
  public ref QAngle AimGoal { get; }
  
  public IGameTime_t TargetSpotTime { get; }
  
  public ref float AimFocus { get; }
  
  public ref float AimFocusInterval { get; }
  
  public IGameTime_t AimFocusNextUpdate { get; }
  
  public ICountdownTimer IgnoreEnemiesTimer { get; }
  
  public ref CHandle<CCSPlayerPawn> Enemy { get; }
  
  public ref bool IsEnemyVisible { get; }
  
  public ref byte VisibleEnemyParts { get; }
  
  public ref Vector LastEnemyPosition { get; }
  
  public ref float LastSawEnemyTimestamp { get; }
  
  public ref float FirstSawEnemyTimestamp { get; }
  
  public ref float CurrentEnemyAcquireTimestamp { get; }
  
  public ref float EnemyDeathTimestamp { get; }
  
  public ref float FriendDeathTimestamp { get; }
  
  public ref bool IsLastEnemyDead { get; }
  
  public ref int NearbyEnemyCount { get; }
  
  public ref CHandle<CCSPlayerPawn> Bomber { get; }
  
  public ref int NearbyFriendCount { get; }
  
  public ref CHandle<CCSPlayerPawn> ClosestVisibleFriend { get; }
  
  public ref CHandle<CCSPlayerPawn> ClosestVisibleHumanFriend { get; }
  
  public IIntervalTimer AttentionInterval { get; }
  
  public ref CHandle<CCSPlayerPawn> Attacker { get; }
  
  public ref float AttackedTimestamp { get; }
  
  public IIntervalTimer BurnedByFlamesTimer { get; }
  
  public ref int LastVictimID { get; }
  
  public ref bool IsAimingAtEnemy { get; }
  
  public ref bool IsRapidFiring { get; }
  
  public IIntervalTimer EquipTimer { get; }
  
  public ICountdownTimer ZoomTimer { get; }
  
  public IGameTime_t FireWeaponTimestamp { get; }
  
  public ICountdownTimer LookForWeaponsOnGroundTimer { get; }
  
  public ref bool IsSleeping { get; }
  
  public ref bool IsEnemySniperVisible { get; }
  
  public ICountdownTimer SawEnemySniperTimer { get; }
  
  public ref byte EnemyQueueIndex { get; }
  
  public ref byte EnemyQueueCount { get; }
  
  public ref byte EnemyQueueAttendIndex { get; }
  
  public ref bool IsStuck { get; }
  
  public IGameTime_t StuckTimestamp { get; }
  
  public ref Vector StuckSpot { get; }
  
  public ICountdownTimer WiggleTimer { get; }
  
  public ICountdownTimer StuckJumpTimer { get; }
  
  public IGameTime_t NextCleanupCheckTimestamp { get; }
  
  public ISchemaFixedArray<float> AvgVel { get; }
  
  public ref int AvgVelIndex { get; }
  
  public ref int AvgVelCount { get; }
  
  public ref Vector LastOrigin { get; }
  
  public ref float LastRadioRecievedTimestamp { get; }
  
  public ref float LastRadioSentTimestamp { get; }
  
  public ref CHandle<CCSPlayerPawn> RadioSubject { get; }
  
  public ref Vector RadioPosition { get; }
  
  public ref float VoiceEndTimestamp { get; }
  
  public ref int LastValidReactionQueueFrame { get; }
}