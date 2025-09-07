using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerGameEvent : CBaseTrigger, ITriggerGameEvent {

  public CTriggerGameEvent(nint handle) : base(handle) {
  }

  public CTriggerGameEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString StrStartTouchEventName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF8B194884B1EB67A));
  }
  public ref CUtlString StrEndTouchEventName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF8B194886EDE6893));
  }
  public ref CUtlString StrTriggerID {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF8B19488EA731D41));
  }

  public void StrStartTouchEventNameUpdated() {
    Schema.Update(_Handle, 0xF8B194884B1EB67A);
  }
  public void StrEndTouchEventNameUpdated() {
    Schema.Update(_Handle, 0xF8B194886EDE6893);
  }
  public void StrTriggerIDUpdated() {
    Schema.Update(_Handle, 0xF8B19488EA731D41);
  }
}