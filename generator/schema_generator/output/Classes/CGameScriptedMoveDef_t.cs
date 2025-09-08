using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameScriptedMoveDef_t : SchemaClass, IGameScriptedMoveDef_t {

  public CGameScriptedMoveDef_t(nint handle) : base(handle) {
  }

  public ref Vector DestOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x278F5D457DA34A6E));
  }
  public ref CHandle<CBaseEntity> DestEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x278F5D45A1CF74EC));
  }
  public ref QAngle Dest {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x278F5D45B61266D7));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x278F5D45BC5E3BAB));
  }
  public ref float AngRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x278F5D4525A03D83));
  }
  public ref float MoveSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x278F5D4566D18279));
  }
  public ref bool AimDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x278F5D457E2FBF2E));
  }
  public ref bool IgnoreRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x278F5D45C7A0F33D));
  }
  public ref ForcedCrouchState_t ForcedCrouchState {
    get => ref _Handle.AsRef<ForcedCrouchState_t>(Schema.GetOffset(0x278F5D4571B1ABC7));
  }


}