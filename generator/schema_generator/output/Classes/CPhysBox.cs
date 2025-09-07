using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysBox : CBreakable, IPhysBox {

  public CPhysBox(nint handle) : base(handle) {
  }

  public CPhysBox(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int DamageType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x914B502B17488B28));
  }
  public ref int DamageToEnableMotion {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x914B502B6A217278));
  }
  public ref float ForceToEnableMotion {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x914B502B95BEED1A));
  }
  public ref Vector HoverPosePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x914B502BE70418E3));
  }
  public ref QAngle HoverPoseAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x914B502B086A1BC6));
  }
  public ref bool NotSolidToWorld {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x914B502B13A06DE8));
  }
  public ref bool EnableUseOutput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x914B502B2426C360));
  }
  public ref HoverPoseFlags_t HoverPoseFlags {
    get => ref _Handle.AsRef<HoverPoseFlags_t>(Schema.GetOffset(0x914B502BE0BEF17B));
  }
  public ref float TouchOutputPerEntityDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x914B502B0F1EF0C0));
  }
  public IEntityIOOutput OnDamaged {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x914B502B1667F41F));
  }
  public IEntityIOOutput OnAwakened {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x914B502B03EDBB66));
  }
  public IEntityIOOutput OnMotionEnabled {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x914B502BBB216C9F));
  }
  public IEntityIOOutput OnPlayerUse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x914B502B611C9A14));
  }
  public IEntityIOOutput OnStartTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x914B502BB4E38193));
  }
  public ref CHandle< CBasePlayerPawn > CarryingPlayer {
    get => ref _Handle.AsRef<CHandle< CBasePlayerPawn >>(Schema.GetOffset(0x914B502B0491B86F));
  }


}