using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseCSGrenadeProjectile : IBaseGrenade {

  public ref Vector InitialPosition { get; }
  
  public ref Vector InitialVelocity { get; }
  
  public ref int Bounces { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> ExplodeEffectIndex { get; }
  
  public ref int ExplodeEffectTickBegin { get; }
  
  public ref Vector ExplodeEffectOrigin { get; }
  
  public IGameTime_t SpawnTime { get; }
  
  public ref byte OGSExtraFlags { get; }
  
  public ref bool DetonationRecorded { get; }
  
  public ref ushort ItemIndex { get; }
  
  public ref Vector OriginalSpawnLocation { get; }
  
  public IGameTime_t LastBounceSoundTime { get; }
  
  public ISchemaUntypedField GrenadeSpin { get; }
  
  public ref Vector LastHitSurfaceNormal { get; }
  
  public ref int TicksAtZeroVelocity { get; }
  
  public ref bool HasEverHitEnemy { get; }
  
}