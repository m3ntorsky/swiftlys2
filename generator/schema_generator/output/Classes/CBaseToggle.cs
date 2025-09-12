using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseToggle : CBaseModelEntity, IBaseToggle {

  public CBaseToggle(nint handle) : base(handle) {
  }

  public ref TOGGLE_STATE Toggle_state {
    get => ref _Handle.AsRef<TOGGLE_STATE>(Schema.GetOffset(0xC466ACE3FAACDE93));
  }
  public ref float MoveDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC466ACE3C39E6D6D));
  }
  public ref float Wait {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC466ACE399A062B6));
  }
  public ref float Lip {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC466ACE387D40000));
  }
  public ref bool AlwaysFireBlockedOutputs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC466ACE3785EA7AA));
  }
  public ref Vector Position1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC466ACE3E24D3941));
  }
  public ref Vector Position2 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC466ACE3DF4D3488));
  }
  public ref QAngle MoveAng {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xC466ACE3BC6F7E1C));
  }
  public ref QAngle Angle1 {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xC466ACE3D44B3E6B));
  }
  public ref QAngle Angle2 {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xC466ACE3D54B3FFE));
  }
  public ref float Height {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC466ACE3EADD7FB0));
  }
  public ref CHandle<CBaseEntity> Activator {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xC466ACE3AB093BB2));
  }
  public ref Vector FinalDest {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC466ACE35F250E93));
  }
  public ref QAngle FinalAngle {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xC466ACE32866F31E));
  }
  public ref int MovementType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC466ACE37CE1B710));
  }
  public ISchemaUntypedField Master {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC466ACE389DC0AE0));
  }


}