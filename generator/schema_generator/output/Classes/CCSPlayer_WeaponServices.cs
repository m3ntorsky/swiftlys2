using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_WeaponServices : CPlayer_WeaponServices, ICSPlayer_WeaponServices {

  public CCSPlayer_WeaponServices(nint handle) : base(handle) {
  }

  public ref CHandle<CBasePlayerWeapon> SavedWeapon {
    get => ref _Handle.AsRef<CHandle<CBasePlayerWeapon>>(Schema.GetOffset(0x13067CB248BC7512));
  }
  public ref int TimeToMelee {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x13067CB2B21B94A7));
  }
  public ref int TimeToSecondary {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x13067CB2CA0FD845));
  }
  public ref int TimeToPrimary {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x13067CB2B1AFDA45));
  }
  public ref int TimeToSniperRifle {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x13067CB2A9FF6B8C));
  }
  public ref bool IsBeingGivenItem {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x13067CB2D16DF82E));
  }
  public ref bool IsPickingUpItemWithUse {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x13067CB2833CCD8D));
  }
  public ref bool PickedUpWeapon {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x13067CB21EEE10C0));
  }
  public ref bool DisableAutoDeploy {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x13067CB2B208C90B));
  }
  public ref bool IsPickingUpGroundWeapon {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x13067CB2CA423D76));
  }

  public void NextAttackUpdated() {
    Schema.Update(_Handle, 0x13067CB23DFDCDEA);
  }
  public void IsLookingAtWeaponUpdated() {
    Schema.Update(_Handle, 0x13067CB223393CBF);
  }
  public void IsHoldingLookAtWeaponUpdated() {
    Schema.Update(_Handle, 0x13067CB2AF0F7486);
  }
  public void NetworkAnimTimingUpdated() {
    Schema.Update(_Handle, 0x13067CB253AFB9FA);
  }
  public void BlockInspectUntilNextGraphUpdateUpdated() {
    Schema.Update(_Handle, 0x13067CB2029ABB28);
  }
}