using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEffectData : SchemaClass, IEffectData {

  public CEffectData(nint handle) : base(handle) {
  }

  public CEffectData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Origin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x15CC7C67F26E589B));
  }
  public ref Vector Start {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x15CC7C67C222DFCB));
  }
  public ref Vector Normal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x15CC7C67AFB36E96));
  }
  public ref QAngle Angles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x15CC7C675658D555));
  }
  public ref CEntityHandle Entity {
    get => ref _Handle.AsRef<CEntityHandle>(Schema.GetOffset(0x15CC7C676EBADCB0));
  }
  public ref CEntityHandle OtherEntity {
    get => ref _Handle.AsRef<CEntityHandle>(Schema.GetOffset(0x15CC7C671E22FE7C));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x15CC7C67B731A42F));
  }
  public ref float Magnitude {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x15CC7C67ED0A1D8B));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x15CC7C675ACFC08D));
  }
  public ref CUtlStringToken SurfaceProp {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x15CC7C6765676439));
  }
  public ref CWeakHandle< InfoForResourceTypeIParticleSystemDefinition > EffectIndex {
    get => ref _Handle.AsRef<CWeakHandle< InfoForResourceTypeIParticleSystemDefinition >>(Schema.GetOffset(0x15CC7C678EBB71E4));
  }
  public ref uint DamageType {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x15CC7C67A9599F54));
  }
  public ref byte Penetrate {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x15CC7C673A561927));
  }
  public ref ushort Material {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x15CC7C67F766BC9C));
  }
  public ref short HitBox {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x15CC7C670B0E1E13));
  }
  public ref byte Color {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x15CC7C6756C9DB94));
  }
  public ref byte Flags {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x15CC7C67A4A37590));
  }
  public IAttachmentHandle_t AttachmentIndex {
    get => new AttachmentHandle_t(_Handle + Schema.GetOffset(0x15CC7C677A529580));
  }
  public ref CUtlStringToken AttachmentName {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0x15CC7C677C04923F));
  }
  public ref ushort EffectName {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x15CC7C67B614AEAE));
  }
  public ref byte ExplosionType {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x15CC7C67D39F3394));
  }

  public void OriginUpdated() {
    Schema.Update(_Handle, 0x15CC7C67F26E589B);
  }
  public void StartUpdated() {
    Schema.Update(_Handle, 0x15CC7C67C222DFCB);
  }
  public void NormalUpdated() {
    Schema.Update(_Handle, 0x15CC7C67AFB36E96);
  }
  public void AnglesUpdated() {
    Schema.Update(_Handle, 0x15CC7C675658D555);
  }
  public void EntityUpdated() {
    Schema.Update(_Handle, 0x15CC7C676EBADCB0);
  }
  public void OtherEntityUpdated() {
    Schema.Update(_Handle, 0x15CC7C671E22FE7C);
  }
  public void ScaleUpdated() {
    Schema.Update(_Handle, 0x15CC7C67B731A42F);
  }
  public void MagnitudeUpdated() {
    Schema.Update(_Handle, 0x15CC7C67ED0A1D8B);
  }
  public void RadiusUpdated() {
    Schema.Update(_Handle, 0x15CC7C675ACFC08D);
  }
  public void SurfacePropUpdated() {
    Schema.Update(_Handle, 0x15CC7C6765676439);
  }
  public void EffectIndexUpdated() {
    Schema.Update(_Handle, 0x15CC7C678EBB71E4);
  }
  public void DamageTypeUpdated() {
    Schema.Update(_Handle, 0x15CC7C67A9599F54);
  }
  public void PenetrateUpdated() {
    Schema.Update(_Handle, 0x15CC7C673A561927);
  }
  public void MaterialUpdated() {
    Schema.Update(_Handle, 0x15CC7C67F766BC9C);
  }
  public void HitBoxUpdated() {
    Schema.Update(_Handle, 0x15CC7C670B0E1E13);
  }
  public void ColorUpdated() {
    Schema.Update(_Handle, 0x15CC7C6756C9DB94);
  }
  public void FlagsUpdated() {
    Schema.Update(_Handle, 0x15CC7C67A4A37590);
  }
  public void AttachmentIndexUpdated() {
    Schema.Update(_Handle, 0x15CC7C677A529580);
  }
  public void AttachmentNameUpdated() {
    Schema.Update(_Handle, 0x15CC7C677C04923F);
  }
  public void EffectNameUpdated() {
    Schema.Update(_Handle, 0x15CC7C67B614AEAE);
  }
  public void ExplosionTypeUpdated() {
    Schema.Update(_Handle, 0x15CC7C67D39F3394);
  }
}