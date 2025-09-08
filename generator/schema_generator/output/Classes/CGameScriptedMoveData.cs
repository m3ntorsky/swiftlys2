using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameScriptedMoveData : SchemaClass, IGameScriptedMoveData {

  public CGameScriptedMoveData(nint handle) : base(handle) {
  }

  public ref Vector AccumulatedRootMotion {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6F78B5E783C65B7B));
  }
  public ref QAngle AccumulatedRootMotionRotation {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x6F78B5E750D6BEEB));
  }
  public ref Vector Src {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6F78B5E74B186FB5));
  }
  public ref QAngle Src {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x6F78B5E79E96F12F));
  }
  public ref QAngle Current {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x6F78B5E72FDA50BC));
  }
  public ref float LockedSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6F78B5E71AD453B4));
  }
  public ref float AngRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6F78B5E725A03D83));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6F78B5E7BC5E3BAB));
  }
  public IGameTime_t StartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x6F78B5E767FE9DC4));
  }
  public ref bool Active {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6F78B5E78334208F));
  }
  public ref bool TeleportOnEnd {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6F78B5E74CE07264));
  }
  public ref bool IgnoreRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6F78B5E7C7A0F33D));
  }
  public ref bool Success {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6F78B5E7BDD1AFF0));
  }
  public ref ForcedCrouchState_t ForcedCrouchState {
    get => ref _Handle.AsRef<ForcedCrouchState_t>(Schema.GetOffset(0x6F78B5E771B1ABC7));
  }
  public ref bool IgnoreCollisions {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6F78B5E7B31AABC2));
  }
  public ref Vector Dest {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6F78B5E784257371));
  }
  public ref QAngle Dst {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x6F78B5E7535FD052));
  }
  public CHandle<IBaseEntity> DestEntity {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x6F78B5E7A1CF74EC));
  }


}