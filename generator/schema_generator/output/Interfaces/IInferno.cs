using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInferno : IBaseModelEntity {

  
  public ISchemaFixedArray<Vector> FirePositions { get; }
  
  public ISchemaFixedArray<Vector> FireParentPositions { get; }
  
  public ISchemaFixedArray<bool> FireIsBurning { get; }
  
  public ISchemaFixedArray<Vector> BurnNormal { get; }
  
  public ref int FireCount { get; }
  
  public ref int InfernoType { get; }
  
  public ref int FireEffectTickBegin { get; }
  
  public ref float FireLifetime { get; }
  
  public ref bool InPostEffectTime { get; }
  
  public ref bool WasCreatedInSmoke { get; }
  
  public IExtent Extent { get; }
  
  public ICountdownTimer DamageTimer { get; }
  
  public ICountdownTimer DamageRampTimer { get; }
  
  public ref Vector SplashVelocity { get; }
  
  public ref Vector InitialSplashVelocity { get; }
  
  public ref Vector StartPos { get; }
  
  public ref Vector OriginalSpawnLocation { get; }
  
  public IIntervalTimer ActiveTimer { get; }
  
  public ref int FireSpawnOffset { get; }
  
  public ref int MaxFlames { get; }
  
  public ref int SpreadCount { get; }
  
  public ICountdownTimer BookkeepingTimer { get; }
  
  public ICountdownTimer NextSpreadTimer { get; }
  
  public ref ushort SourceItemDefIndex { get; }
}