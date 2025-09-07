using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsProp : CBreakableProp, IPhysicsProp {

  public CPhysicsProp(nint handle) : base(handle) {
  }

  public CPhysicsProp(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput MotionEnabled {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC3FD37FE8956B83C));
  }
  public IEntityIOOutput OnAwakened {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC3FD37FE03EDBB66));
  }
  public IEntityIOOutput OnAwake {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC3FD37FEE3FE59B3));
  }
  public IEntityIOOutput OnAsleep {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC3FD37FE8CFD4346));
  }
  public IEntityIOOutput OnPlayerUse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC3FD37FE611C9A14));
  }
  public IEntityIOOutput OnOutOfWorld {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC3FD37FE3016DC53));
  }
  public IEntityIOOutput OnPlayerPickup {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC3FD37FEDE81BF25));
  }
  public ref bool ForceNavIgnore {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE5A6B880F));
  }
  public ref bool NoNavmeshBlocker {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FEED423D60));
  }
  public ref bool ForceNpcExclude {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE4194963F));
  }
  public ref float MassScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3FD37FE01B9E905));
  }
  public ref float BuoyancyScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3FD37FE296C36AB));
  }
  public ref int DamageType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3FD37FE17488B28));
  }
  public ref int DamageToEnableMotion {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3FD37FE6A217278));
  }
  public ref float ForceToEnableMotion {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3FD37FE95BEED1A));
  }
  public ref bool ThrownByPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE313A0B97));
  }
  public ref bool DroppedByPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FEAE58B7C9));
  }
  public ref bool TouchedByPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE3D91E55D));
  }
  public ref bool FirstCollisionAfterLaunch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FEC9D93EAC));
  }
  public ref bool HasBeenAwakened {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE93DAAC9B));
  }
  public ref bool IsOverrideProp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE43F03A10));
  }
  public IGameTime_t LastBurn {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xC3FD37FE7EF64B16));
  }
  public ref DynamicContinuousContactBehavior_t DynamicContinuousContactBehavior {
    get => ref _Handle.AsRef<DynamicContinuousContactBehavior_t>(Schema.GetOffset(0xC3FD37FE4846D0CD));
  }
  public IGameTime_t NextCheckDisableMotionContactsTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xC3FD37FE50052C1A));
  }
  public ref int InitialGlowState {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3FD37FE5260376A));
  }
  public ref int GlowRange {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3FD37FED03F97ED));
  }
  public ref int GlowRangeMin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3FD37FEA28EDB1F));
  }
  public ref Color GlowColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xC3FD37FE74A5EE03));
  }
  public ref bool ShouldAutoConvertBackFromDebris {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE456AC920));
  }
  public ref bool MuteImpactEffects {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE8D5DDE78));
  }
  public ref bool AcceptDamageFromHeldObjects {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE6B4982E1));
  }
  public ref bool EnableUseOutput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE2426C360));
  }
  public ref CPhysicsProp::CrateType_t CrateType {
    get => ref _Handle.AsRef<CPhysicsProp::CrateType_t>(Schema.GetOffset(0xC3FD37FE5B05CA48));
  }
  public ISchemaFixedArray<CUtlSymbolLarge> StrItemClass {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle + Schema.GetOffset(0xC3FD37FE35D963A1));
  }
  public ISchemaFixedArray<int32> ItemCount {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0xC3FD37FEA5886501));
  }
  public ref bool RemovableForAmmoBalancing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FEF629CF16));
  }
  public ref bool Awake {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FE9A5C15BC));
  }
  public ref bool AttachedToReferenceFrame {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3FD37FED2A5449A));
  }

  public void AwakeUpdated() {
    Schema.Update(_Handle, 0xC3FD37FE9A5C15BC);
  }
}