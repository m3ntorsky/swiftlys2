using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseGrenade : IBaseFlex {

  
  public IEntityIOOutput OnPlayerPickup { get; }
  
  public IEntityIOOutput OnExplode { get; }
  
  public ref bool HasWarnedAI { get; }
  
  public ref bool IsSmokeGrenade { get; }
  
  public ref bool IsLive { get; }
  
  public ref float DmgRadius { get; }
  
  public IGameTime_t DetonateTime { get; }
  
  public ref float WarnAITime { get; }
  
  public ref float Damage { get; }
  
  public ISchemaUntypedField BounceSound { get; }
  
  public ref CUtlString ExplosionSound { get; }
  
  public ref CHandle<CCSPlayerPawn> Thrower { get; }
  
  public IGameTime_t NextAttack { get; }
  
  public ref CHandle<CCSPlayerPawn> OriginalThrower { get; }
}