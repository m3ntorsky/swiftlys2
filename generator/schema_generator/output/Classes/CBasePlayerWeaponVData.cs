using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBasePlayerWeaponVData : CEntitySubclassVDataBase, IBasePlayerWeaponVData {

  public CBasePlayerWeaponVData(nint handle) : base(handle) {
  }

  public ISchemaUntypedField WorldModel {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x64E418A0B9041909));
  }
  public ISchemaUntypedField ToolsOnlyOwnerModelName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x64E418A06DD9DD04));
  }
  public ref bool BuiltRightHanded {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E418A08857B74F));
  }
  public ref bool AllowFlipping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E418A01B594D05));
  }
  public ISchemaUntypedField MuzzleAttachment {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x64E418A0E8A8FEA2));
  }
  public ISchemaUntypedField MuzzleFlashParticle {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x64E418A0CE0726A3));
  }
  public ref CUtlString MuzzleFlashParticleConfig {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x64E418A029D7C081));
  }
  public ISchemaUntypedField BarrelSmokeParticle {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x64E418A03406364F));
  }
  public ref byte MuzzleSmokeShotThreshold {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x64E418A036780024));
  }
  public ref float MuzzleSmokeTimeout {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64E418A06F626E1A));
  }
  public ref float MuzzleSmokeDecrementRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64E418A0B407F926));
  }
  public ref bool LinkedCooldowns {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E418A039951A46));
  }
  public ref ItemFlagTypes_t Flags {
    get => ref _Handle.AsRef<ItemFlagTypes_t>(Schema.GetOffset(0x64E418A01873A1F7));
  }
  public IAmmoIndex_t PrimaryAmmoType {
    get => new AmmoIndex_t(_Handle + Schema.GetOffset(0x64E418A05686E507));
  }
  public IAmmoIndex_t SecondaryAmmoType {
    get => new AmmoIndex_t(_Handle + Schema.GetOffset(0x64E418A046D1E9A7));
  }
  public ref int MaxClip1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64E418A0EF951A4F));
  }
  public ref int MaxClip2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64E418A0F0951BE2));
  }
  public ref int DefaultClip1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64E418A0999A5252));
  }
  public ref int DefaultClip2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64E418A0989A50BF));
  }
  public ref bool ReserveAmmoAsClips {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E418A016F78884));
  }
  public ref bool TreatAsSingleClip {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E418A01B25858D));
  }
  public ref int Weight {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64E418A054A5EA14));
  }
  public ref bool AutoSwitchTo {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E418A01E225763));
  }
  public ref bool AutoSwitchFrom {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E418A01E5E509A));
  }
  public ref RumbleEffect_t RumbleEffect {
    get => ref _Handle.AsRef<RumbleEffect_t>(Schema.GetOffset(0x64E418A0C5F24460));
  }
  public ref float DropSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64E418A005B18969));
  }
  public ref int Slot {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64E418A0AC7A8798));
  }
  public ref int Position {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64E418A00617DD77));
  }
  public ISchemaUntypedField ShootSounds {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x64E418A0DF14A83B));
  }


}