using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerPush : CBaseTrigger, ITriggerPush {

  public CTriggerPush(nint handle) : base(handle) {
  }

  public ref QAngle PushEntitySpace {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x92E0F2F21952BFD6));
  }
  public ref Vector PushDirEntitySpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x92E0F2F2A3C4D4F3));
  }
  public ref bool TriggerOnStartTouch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x92E0F2F2365C0A51));
  }
  public ref bool UsePathSimple {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x92E0F2F21BFD6EF1));
  }
  public ISchemaUntypedField PathSimpleName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x92E0F2F2AB7E7D7F));
  }
  public IPathSimple PathSimple {
    get => new CPathSimple(_Handle + Schema.GetOffset(0x92E0F2F2FA868DCC));
  }
  public ref uint SplinePushType {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x92E0F2F229A29DE0));
  }


}