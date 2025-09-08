using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerPawn : ICSPlayerPawnBase {

  public ICSPlayer_BulletServices BulletServices { get; }
  
  public ICSPlayer_HostageServices HostageServices { get; }
  
  public ICSPlayer_BuyServices BuyServices { get; }
  
  public ICSPlayer_ActionTrackingServices ActionTrackingServices { get; }
  
  public ICSPlayer_RadioServices RadioServices { get; }
  
  public ICSPlayer_DamageReactServices DamageReactServices { get; }
  
  public ref ushort CharacterDefIndex { get; }
  
  public ref bool HasFemaleVoice { get; }
  
  public ref CUtlString StrVOPrefix { get; }
  
  public ISchemaFixedString LastPlaceName { get; }
  
  public ref bool InHostageResetZone { get; }
  
  public ref bool InBuyZone { get; }
  
  public ref CUtlVector TouchingBuyZones { get; }
  
  public ref bool WasInBuyZone { get; }
  
  public ref bool InHostageRescueZone { get; }
  
  public ref bool InBombZone { get; }
  
  public ref bool WasInHostageRescueZone { get; }
  
  public ref int RetakesOffering { get; }
  
  public ref int RetakesOfferingCard { get; }
  
  public ref bool RetakesHasDefuseKit { get; }
  
  public ref bool RetakesMVPLastRound { get; }
  
  public ref int RetakesMVPBoostItem { get; }
  
  public ref loadout_slot_t RetakesMVPBoostExtraUtility { get; }
  
  public IGameTime_t HealthShotBoostExpirationTime { get; }
  
  public ref float LandingTimeSeconds { get; }
  
  public ref QAngle AimPunchAngle { get; }
  
  public ref QAngle AimPunchAngleVel { get; }
  
  public ref int AimPunchTickBase { get; }
  
  public ref float AimPunchTickFraction { get; }
  
  public ref CUtlVector<QAngle> AimPunchCache { get; }
  
  public ref bool IsBuyMenuOpen { get; }
  
  public ref CTransform XLastHeadBoneTransform { get; }
  
  public ref bool LastHeadBoneTransformIsValid { get; }
  
  public IGameTime_t LastLandTime { get; }
  
  public ref bool OnGroundLastTick { get; }
  
  public ref int PlayerLocked { get; }
  
  public IGameTime_t TimeOfLastInjury { get; }
  
  public IGameTime_t NextSprayDecalTime { get; }
  
  public ref bool NextSprayDecalTimeExpedited { get; }
  
  public ref int RagdollDamageBone { get; }
  
  public ref Vector RagdollDamageForce { get; }
  
  public ref Vector RagdollDamagePosition { get; }
  
  public ISchemaFixedString RagdollDamageWeaponName { get; }
  
  public ref bool RagdollDamageHeadshot { get; }
  
  public ref Vector RagdollServerOrigin { get; }
  
  public IEconItemView EconGloves { get; }
  
  public ref byte EconGlovesChanged { get; }
  
  public ref QAngle DeathEyeAngles { get; }
  
  public ref bool SkipOneHeadConstraintUpdate { get; }
  
  public ref bool LeftHanded { get; }
  
  public IGameTime_t SwitchedHandednessTime { get; }
  
  public ref float ViewmodelOffsetX { get; }
  
  public ref float ViewmodelOffsetY { get; }
  
  public ref float ViewmodelOffsetZ { get; }
  
  public ref float ViewmodelFOV { get; }
  
  public ref bool IsWalking { get; }
  
  public ref float LastGivenDefuserTime { get; }
  
  public ref float LastGivenBombTime { get; }
  
  public ref float DealtDamageToEnemyMostRecentTimestamp { get; }
  
  public ref uint DisplayHistoryBits { get; }
  
  public ref float LastAttackedTeammate { get; }
  
  public IGameTime_t AllowAutoFollowTime { get; }
  
  public ref bool ResetArmorNextSpawn { get; }
  
  public ref CEntityIndex LastKillerIndex { get; }
  
  public IEntitySpottedState_t EntitySpottedState { get; }
  
  public ref int SpotRules { get; }
  
  public ref bool IsScoped { get; }
  
  public ref bool ResumeZoom { get; }
  
  public ref bool IsDefusing { get; }
  
  public ref bool IsGrabbingHostage { get; }
  
  public ref CSPlayerBlockingUseAction_t BlockingUseActionInProgress { get; }
  
  public IGameTime_t EmitSoundTime { get; }
  
  public ref bool InNoDefuseArea { get; }
  
  public ref CEntityIndex BombSiteIndex { get; }
  
  public ref int WhichBombZone { get; }
  
  public ref bool InBombZoneTrigger { get; }
  
  public ref bool WasInBombZoneTrigger { get; }
  
  public ref int ShotsFired { get; }
  
  public ref float FlinchStack { get; }
  
  public ref float VelocityModifier { get; }
  
  public ref float HitHeading { get; }
  
  public ref int HitBodyPart { get; }
  
  public ref Vector TotalBulletForce { get; }
  
  public ref bool WaitForNoAttack { get; }
  
  public ref float IgnoreLadderJumpTime { get; }
  
  public ref bool KilledByHeadshot { get; }
  
  public ref int LastHitBox { get; }
  
  public ref int LastHealth { get; }
  
  public ICSBot Bot { get; }
  
  public ref bool BotAllowActive { get; }
  
  public ref QAngle ThirdPersonHeading { get; }
  
  public ref float SlopeDropOffset { get; }
  
  public ref float SlopeDropHeight { get; }
  
  public ref Vector HeadConstraintOffset { get; }
  
  public ref int LastPickupPriority { get; }
  
  public ref float LastPickupPriorityTime { get; }
  
  public ref int ArmorValue { get; }
  
  public ref ushort CurrentEquipmentValue { get; }
  
  public ref ushort RoundStartEquipmentValue { get; }
  
  public ref ushort FreezetimeEndEquipmentValue { get; }
  
  public ref int LastWeaponFireUsercmd { get; }
  
  public ref bool IsSpawning { get; }
  
  public ref int DeathFlags { get; }
  
  public ref bool HasDeathInfo { get; }
  
  public ref float DeathInfoTime { get; }
  
  public ref Vector DeathInfoOrigin { get; }
  
  public ISchemaFixedArray<uint> PlayerPatchEconIndices { get; }
  
  public ref Color GunGameImmunityColor { get; }
  
  public IGameTime_t GrenadeParameterStashTime { get; }
  
  public ref bool GrenadeParametersStashed { get; }
  
  public ref QAngle StashedShootAngles { get; }
  
  public ref Vector StashedGrenadeThrowPosition { get; }
  
  public ref Vector StashedVelocity { get; }
  
  public ISchemaFixedArray<QAngle> ShootAngleHistory { get; }
  
  public ISchemaFixedArray<Vector> ThrowPositionHistory { get; }
  
  public ISchemaFixedArray<Vector> VelocityHistory { get; }
  
  public ref CUtlVectorEmbeddedNetworkVar PredictedDamageTags { get; }
  
  public ref int HighestAppliedDamageTagTick { get; }
  
  public ref bool CommittingSuicideOnTeamChange { get; }
  
  public ref bool WasNotKilledNaturally { get; }
  
  public IGameTime_t ImmuneToGunGameDamageTime { get; }
  
  public ref bool GunGameImmunity { get; }
  
  public ref float MolotovDamageTime { get; }
  
  public ref QAngle EyeAngles { get; }
  
}