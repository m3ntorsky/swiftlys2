using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseModelEntity : IBaseEntity {

  public IRenderComponent CRenderComponent { get; }
  
  public IHitboxComponent CHitboxComponent { get; }
  
  public ref HitGroup_t DestructiblePartInitialStateDestructed0 { get; }
  
  public ref HitGroup_t DestructiblePartInitialStateDestructed1 { get; }
  
  public ref HitGroup_t DestructiblePartInitialStateDestructed2 { get; }
  
  public ref HitGroup_t DestructiblePartInitialStateDestructed3 { get; }
  
  public ref HitGroup_t DestructiblePartInitialStateDestructed4 { get; }
  
  public ref int DestructiblePartInitialStateDestructed0_PartIndex { get; }
  
  public ref int DestructiblePartInitialStateDestructed1_PartIndex { get; }
  
  public ref int DestructiblePartInitialStateDestructed2_PartIndex { get; }
  
  public ref int DestructiblePartInitialStateDestructed3_PartIndex { get; }
  
  public ref int DestructiblePartInitialStateDestructed4_PartIndex { get; }
  
  public IDestructiblePartsSystemComponent DestructiblePartsSystemComponent { get; }
  
  public ref HitGroup_t LastHitGroup { get; }
  
  public ref CGlobalSymbol LastDamageSourceName { get; }
  
  public ref Vector LastDamagePosition { get; }
  
  public IGameTime_t DissolveStartTime { get; }
  
  public IEntityIOOutput OnIgnite { get; }
  
  public ref RenderMode_t RenderMode { get; }
  
  public ref RenderFx_t RenderFX { get; }
  
  public ref bool AllowFadeInView { get; }
  
  public ref Color Render { get; }
  
  public ref CUtlVectorEmbeddedNetworkVar RenderAttributes { get; }
  
  public ref bool RenderToCubemaps { get; }
  
  public ref bool NoInterpolate { get; }
  
  public ICollisionProperty Collision { get; }
  
  public IGlowProperty Glow { get; }
  
  public ref float GlowBackfaceMult { get; }
  
  public ref float FadeMinDist { get; }
  
  public ref float FadeMaxDist { get; }
  
  public ref float FadeScale { get; }
  
  public ref float ShadowStrength { get; }
  
  public ref byte ObjectCulling { get; }
  
  public ref int AddDecal { get; }
  
  public ref Vector DecalPosition { get; }
  
  public ref Vector DecalForwardAxis { get; }
  
  public ref float DecalHealBloodRate { get; }
  
  public ref float DecalHealHeightRate { get; }
  
  public ref DecalMode_t DecalMode { get; }
  
  public ref DecalMode_t RequiredDecalMode { get; }
  
  public ref CUtlVector<CHandle<CBaseModelEntity>> ConfigEntitiesToPropagateMaterialDecalsTo { get; }
  
  public INetworkViewOffsetVector ViewOffset { get; }
  
}