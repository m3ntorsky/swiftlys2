using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseModelEntity : CBaseEntity, IBaseModelEntity {

  public CBaseModelEntity(nint handle) : base(handle) {
  }

  public ref HitGroup_t DestructiblePartInitialStateDestructed0 {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0x517849F747691C40));
  }
  public ref HitGroup_t DestructiblePartInitialStateDestructed1 {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0x517849F748691DD3));
  }
  public ref HitGroup_t DestructiblePartInitialStateDestructed2 {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0x517849F749691F66));
  }
  public ref HitGroup_t DestructiblePartInitialStateDestructed3 {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0x517849F74A6920F9));
  }
  public ref HitGroup_t DestructiblePartInitialStateDestructed4 {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0x517849F74B69228C));
  }
  public ref int DestructiblePartInitialStateDestructed0_PartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x517849F7D7803958));
  }
  public ref int DestructiblePartInitialStateDestructed1_PartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x517849F7F18ACB17));
  }
  public ref int DestructiblePartInitialStateDestructed2_PartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x517849F75197A2DA));
  }
  public ref int DestructiblePartInitialStateDestructed3_PartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x517849F7A59BCFC9));
  }
  public ref int DestructiblePartInitialStateDestructed4_PartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x517849F76D7C6A3C));
  }
  public ref HitGroup_t LastHitGroup {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0x517849F7EE206371));
  }
  public ref CGlobalSymbol LastDamageSourceName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x517849F704D101A5));
  }
  public ref Vector LastDamagePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x517849F772774B0B));
  }
  public IGameTime_t DissolveStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x517849F7833C5731));
  }
  public IEntityIOOutput OnIgnite {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x517849F757BDA972));
  }
  public ref bool AllowFadeInView {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x517849F7CDE3B31E));
  }

  public void CRenderComponentUpdated() {
    Schema.Update(_Handle, 0x517849F7E8F59505);
  }
  public void CHitboxComponentUpdated() {
    Schema.Update(_Handle, 0x517849F70E786123);
  }
  public void DestructiblePartsSystemComponentUpdated() {
    Schema.Update(_Handle, 0x517849F77992C14B);
  }
  public void RenderModeUpdated() {
    Schema.Update(_Handle, 0x517849F7679967A6);
  }
  public void RenderFXUpdated() {
    Schema.Update(_Handle, 0x517849F7E510717F);
  }
  public void RenderUpdated() {
    Schema.Update(_Handle, 0x517849F7470D2A38);
  }
  public void RenderAttributesUpdated() {
    Schema.Update(_Handle, 0x517849F7BF74B4AC);
  }
  public void RenderToCubemapsUpdated() {
    Schema.Update(_Handle, 0x517849F78A23364A);
  }
  public void NoInterpolateUpdated() {
    Schema.Update(_Handle, 0x517849F76E001CB9);
  }
  public void CollisionUpdated() {
    Schema.Update(_Handle, 0x517849F7AE8E690F);
  }
  public void GlowUpdated() {
    Schema.Update(_Handle, 0x517849F7A7E70C3C);
  }
  public void GlowBackfaceMultUpdated() {
    Schema.Update(_Handle, 0x517849F74F285CEE);
  }
  public void FadeMinDistUpdated() {
    Schema.Update(_Handle, 0x517849F77FBCF6A9);
  }
  public void FadeMaxDistUpdated() {
    Schema.Update(_Handle, 0x517849F70B8328FB);
  }
  public void FadeScaleUpdated() {
    Schema.Update(_Handle, 0x517849F786B56425);
  }
  public void ShadowStrengthUpdated() {
    Schema.Update(_Handle, 0x517849F73F1ED282);
  }
  public void ObjectCullingUpdated() {
    Schema.Update(_Handle, 0x517849F71A0D757A);
  }
  public void AddDecalUpdated() {
    Schema.Update(_Handle, 0x517849F75E07F29D);
  }
  public void DecalPositionUpdated() {
    Schema.Update(_Handle, 0x517849F7939EEE2D);
  }
  public void DecalForwardAxisUpdated() {
    Schema.Update(_Handle, 0x517849F78CF4767A);
  }
  public void DecalHealBloodRateUpdated() {
    Schema.Update(_Handle, 0x517849F7E19E95D8);
  }
  public void DecalHealHeightRateUpdated() {
    Schema.Update(_Handle, 0x517849F7BDF5A793);
  }
  public void DecalModeUpdated() {
    Schema.Update(_Handle, 0x517849F7C6AE5101);
  }
  public void RequiredDecalModeUpdated() {
    Schema.Update(_Handle, 0x517849F7CBD7293E);
  }
  public void ConfigEntitiesToPropagateMaterialDecalsToUpdated() {
    Schema.Update(_Handle, 0x517849F75FD9715A);
  }
  public void ViewOffsetUpdated() {
    Schema.Update(_Handle, 0x517849F739DB834B);
  }
}