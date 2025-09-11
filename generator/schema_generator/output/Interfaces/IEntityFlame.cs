using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityFlame : IBaseEntity {

  
  public ref CHandle<CBaseEntity> EntAttached { get; }
  
  public ref bool CheapEffect { get; }
  
  public ref float Size { get; }
  
  public ref bool UseHitboxes { get; }
  
  public ref int NumHitboxFires { get; }
  
  public ref float HitboxFireScale { get; }
  
  public IGameTime_t Lifetime { get; }
  
  public ref CHandle<CBaseEntity> Attacker { get; }
  
  public ref float DirectDamagePerSecond { get; }
  
  public ref int CustomDamageType { get; }
}