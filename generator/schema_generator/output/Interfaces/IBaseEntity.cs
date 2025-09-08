using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseEntity : IEntityInstance {

  public IBodyComponent CBodyComponent { get; }
  
  public INetworkTransmitComponent NetworkTransmitComponent { get; }
  
  public ref CUtlVector ThinkFunctions { get; }
  
  public ref int CurrentThinkContext { get; }
  
  public IGameTick_t LastThinkTick { get; }
  
  public ref bool DisabledContextThinks { get; }
  
  public ref CBitVec<64> IsSteadyState { get; }
  
  public ref float LastNetworkChange { get; }
  
  public ref CUtlVector ResponseContexts { get; }
  
  public ref CUtlSymbolLarge ResponseContext { get; }
  
  public ref int Health { get; }
  
  public ref int MaxHealth { get; }
  
  public ref byte LifeState { get; }
  
  public ref float DamageAccumulator { get; }
  
  public ref bool TakesDamage { get; }
  
  public ref TakeDamageFlags_t TakeDamageFlags { get; }
  
  public ref EntityPlatformTypes_t PlatformType { get; }
  
  public ref MoveCollide_t MoveCollide { get; }
  
  public ref MoveType_t MoveType { get; }
  
  public ref MoveType_t ActualMoveType { get; }
  
  public ref byte WaterTouch { get; }
  
  public ref byte SlimeTouch { get; }
  
  public ref bool RestoreInHierarchy { get; }
  
  public ref CUtlSymbolLarge Target { get; }
  
  public CHandle<IBaseFilter> DamageFilter { get; }
  
  public ref CUtlSymbolLarge DamageFilterName { get; }
  
  public ref float MoveDoneTime { get; }
  
  public ref CUtlStringToken SubclassID { get; }
  
  public ref float AnimTime { get; }
  
  public ref float SimulationTime { get; }
  
  public IGameTime_t CreateTime { get; }
  
  public ref bool ClientSideRagdoll { get; }
  
  public ref byte InterpolationFrame { get; }
  
  public ref Vector PrevVPhysicsUpdatePos { get; }
  
  public ref byte TeamNum { get; }
  
  public ref CUtlSymbolLarge Globalname { get; }
  
  public ref int SentToClients { get; }
  
  public ref float Speed { get; }
  
  public ref CUtlString UniqueHammerID { get; }
  
  public ref uint Spawnflags { get; }
  
  public IGameTick_t NextThinkTick { get; }
  
  public ref int SimulationTick { get; }
  
  public IEntityIOOutput OnKilled { get; }
  
  public ref uint Flags { get; }
  
  public ref Vector AbsVelocity { get; }
  
  public INetworkVelocityVector Velocity { get; }
  
  public ref Vector BaseVelocity { get; }
  
  public ref int PushEnumCount { get; }
  
  public ICollisionProperty Collision { get; }
  
  public CHandle<IBaseEntity> EffectEntity { get; }
  
  public CHandle<IBaseEntity> OwnerEntity { get; }
  
  public ref uint Effects { get; }
  
  public CHandle<IBaseEntity> GroundEntity { get; }
  
  public ref int GroundBodyIndex { get; }
  
  public ref float Friction { get; }
  
  public ref float Elasticity { get; }
  
  public ref float GravityScale { get; }
  
  public ref float TimeScale { get; }
  
  public ref float WaterLevel { get; }
  
  public ref bool GravityDisabled { get; }
  
  public ref bool AnimatedEveryTick { get; }
  
  public ref float ActualGravityScale { get; }
  
  public ref bool GravityActuallyDisabled { get; }
  
  public ref bool DisableLowViolence { get; }
  
  public ref byte WaterType { get; }
  
  public ref int EFlags { get; }
  
  public IEntityIOOutput OnUser1 { get; }
  
  public IEntityIOOutput OnUser2 { get; }
  
  public IEntityIOOutput OnUser3 { get; }
  
  public IEntityIOOutput OnUser4 { get; }
  
  public ref int InitialTeamNum { get; }
  
  public IGameTime_t NavIgnoreUntilTime { get; }
  
  public ref QAngle AngVelocity { get; }
  
  public ref bool NetworkQuantizeOriginAndAngles { get; }
  
  public ref bool LagCompensate { get; }
  
  public CHandle<IBaseEntity> Blocker { get; }
  
  public ref float LocalTime { get; }
  
  public ref float VPhysicsUpdateLocalTime { get; }
  
  public ref BloodType BloodType { get; }
  
  public IPulseGraphInstance_ServerEntity PulseGraphInstance { get; }
  
}