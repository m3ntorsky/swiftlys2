using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollProp : IBaseAnimGraph {

  public Iragdoll_t Ragdoll { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref CUtlVector<bool> RagEnabled { get; }
  
  public ref CUtlVector<Vector> RagPos { get; }
  
  public ref CUtlVector<QAngle> RagAngles { get; }
  
  public CHandle<IBaseEntity> RagdollSource { get; }
  
  public ref uint LastUpdateTickCount { get; }
  
  public ref bool AllAsleep { get; }
  
  public ref bool FirstCollisionAfterLaunch { get; }
  
  public CHandle<IBaseEntity> DamageEntity { get; }
  
  public CHandle<IBaseEntity> Killer { get; }
  
  public CHandle<IBasePlayerPawn> PhysicsAttacker { get; }
  
  public IGameTime_t LastPhysicsInfluenceTime { get; }
  
  public IGameTime_t FadeOutStartTime { get; }
  
  public ref float FadeTime { get; }
  
  public ref Vector LastOrigin { get; }
  
  public IGameTime_t AwakeTime { get; }
  
  public IGameTime_t LastOriginChangeTime { get; }
  
  public ref CUtlSymbolLarge StrOriginClassName { get; }
  
  public ref CUtlSymbolLarge StrSourceClassName { get; }
  
  public ref bool HasBeenPhysgunned { get; }
  
  public ref bool ShouldTeleportPhysics { get; }
  
  public ref bool AllowStretch { get; }
  
  public ref float BlendWeight { get; }
  
  public ref float DefaultFadeScale { get; }
  
  public ref CUtlVector<Vector> RagdollMins { get; }
  
  public ref CUtlVector<Vector> RagdollMaxs { get; }
  
  public ref bool ShouldDeleteActivationRecord { get; }
  
  public ref bool ValidatePoweredRagdollPose { get; }
  
}