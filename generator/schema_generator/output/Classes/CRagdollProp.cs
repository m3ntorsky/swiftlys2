using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollProp : CBaseAnimGraph, IRagdollProp {

  public CRagdollProp(nint handle) : base(handle) {
  }

  public Iragdoll_t Ragdoll {
    get => new ragdoll_t(_Handle + Schema.GetOffset(0x9505BA78F62C6568));
  }
  public ref bool StartDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA7861ED0C4F));
  }
  public ref uint LastUpdateTickCount {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9505BA785A98C204));
  }
  public ref bool AllAsleep {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA783DE13402));
  }
  public ref bool FirstCollisionAfterLaunch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA78C9D93EAC));
  }
  public CHandle<IBaseEntity> DamageEntity {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x9505BA784C4C28C5));
  }
  public CHandle<IBaseEntity> Killer {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x9505BA780F088B1C));
  }
  public CHandle<IBasePlayerPawn> PhysicsAttacker {
    get => new CHandle<CBasePlayerPawn>(_Handle + Schema.GetOffset(0x9505BA787A5EB877));
  }
  public IGameTime_t LastPhysicsInfluenceTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x9505BA785B5C0E32));
  }
  public IGameTime_t FadeOutStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x9505BA78A63078C0));
  }
  public ref float FadeTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9505BA7800BEDB08));
  }
  public ref Vector LastOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9505BA78F13D764B));
  }
  public IGameTime_t AwakeTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x9505BA78D471FE9B));
  }
  public IGameTime_t LastOriginChangeTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x9505BA78B66C9A18));
  }
  public ref CUtlSymbolLarge StrOriginClassName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9505BA7809148529));
  }
  public ref CUtlSymbolLarge StrSourceClassName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9505BA78F3FD1A0C));
  }
  public ref bool HasBeenPhysgunned {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA785058D154));
  }
  public ref bool ShouldTeleportPhysics {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA7828013FEA));
  }
  public ref bool AllowStretch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA78F6CDF40F));
  }
  public ref float DefaultFadeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9505BA784DA9700C));
  }
  public ref CUtlVector<Vector> RagdollMins {
    get => ref _Handle.AsRef<CUtlVector<Vector>>(Schema.GetOffset(0x9505BA78CD1755B5));
  }
  public ref CUtlVector<Vector> RagdollMaxs {
    get => ref _Handle.AsRef<CUtlVector<Vector>>(Schema.GetOffset(0x9505BA7833F9714F));
  }
  public ref bool ShouldDeleteActivationRecord {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA7838134064));
  }
  public ref bool ValidatePoweredRagdollPose {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9505BA787CE03CDD));
  }

  public void RagEnabledUpdated() {
    Schema.Update(_Handle, 0x9505BA78CD1FB84A);
  }
  public void RagPosUpdated() {
    Schema.Update(_Handle, 0x9505BA7897C85315);
  }
  public void RagAnglesUpdated() {
    Schema.Update(_Handle, 0x9505BA78FD4E530D);
  }
  public void RagdollSourceUpdated() {
    Schema.Update(_Handle, 0x9505BA7835E0724F);
  }
  public void BlendWeightUpdated() {
    Schema.Update(_Handle, 0x9505BA78E5D6B9CE);
  }
}