using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTakeDamageInfo : SchemaClass, ITakeDamageInfo {

  public CTakeDamageInfo(nint handle) : base(handle) {
  }

  public ref Vector DamageForce {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE30E6228A2BCC293));
  }
  public ref Vector DamagePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE30E6228AC86A503));
  }
  public ref Vector ReportedPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE30E6228FEEB7B75));
  }
  public ref Vector DamageDirection {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE30E622819986F61));
  }
  public ref CHandle<CBaseEntity> Inflictor {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xE30E62284D7B4137));
  }
  public ref CHandle<CBaseEntity> Attacker {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xE30E622868573D54));
  }
  public ref CHandle<CBaseEntity> Ability {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xE30E622825B1260B));
  }
  public ref float Damage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE30E6228DC60E53E));
  }
  public ref float TotalledDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE30E6228BCA53339));
  }
  public ref DamageTypes_t BitsDamageType {
    get => ref _Handle.AsRef<DamageTypes_t>(Schema.GetOffset(0xE30E6228EEAC35FC));
  }
  public ref int DamageCustom {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE30E6228433BDE1E));
  }
  public IAmmoIndex_t AmmoType {
    get => new AmmoIndex_t(_Handle + Schema.GetOffset(0xE30E6228BDE8294A));
  }
  public ref float OriginalDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE30E622885B50515));
  }
  public ref bool ShouldBleed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE30E6228DD0CFB3A));
  }
  public ref bool ShouldSpark {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE30E6228232BCA77));
  }
  public ref TakeDamageFlags_t DamageFlags {
    get => ref _Handle.AsRef<TakeDamageFlags_t>(Schema.GetOffset(0xE30E622819B0DFEF));
  }
  public ref CGlobalSymbol DamageSourceName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xE30E6228A4EFA6D1));
  }
  public ref HitGroup_t HitGroupId {
    get => ref _Handle.AsRef<HitGroup_t>(Schema.GetOffset(0xE30E6228550440CD));
  }
  public ref int NumObjectsPenetrated {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE30E6228AE07FC1D));
  }
  public ref float FriendlyFireDamageReductionRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE30E62287636BEAD));
  }
  public ref bool InTakeDamageFlow {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE30E6228E9AED258));
  }


}