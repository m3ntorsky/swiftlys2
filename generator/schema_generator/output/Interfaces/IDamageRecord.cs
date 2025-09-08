using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDamageRecord : ISchemaClass {

  public CHandle<ICSPlayerPawn> PlayerDamager { get; }
  
  public CHandle<ICSPlayerPawn> PlayerRecipient { get; }
  
  public CHandle<ICSPlayerController> PlayerControllerDamager { get; }
  
  public CHandle<ICSPlayerController> PlayerControllerRecipient { get; }
  
  public ref CUtlString PlayerDamagerName { get; }
  
  public ref CUtlString PlayerRecipientName { get; }
  
  public ref ulong DamagerXuid { get; }
  
  public ref ulong RecipientXuid { get; }
  
  public ref int BulletsDamage { get; }
  
  public ref int Damage { get; }
  
  public ref int ActualHealthRemoved { get; }
  
  public ref int NumHits { get; }
  
  public ref int LastBulletUpdate { get; }
  
  public ref bool IsOtherEnemy { get; }
  
  public ref EKillTypes_t KillType { get; }
  
}