using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerLerpObject : CBaseTrigger, ITriggerLerpObject {

  public CTriggerLerpObject(nint handle) : base(handle) {
  }

  public CTriggerLerpObject(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge LerpTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x42FE8EA4853F2479));
  }
  public ref CHandle< CBaseEntity > LerpTarget {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x42FE8EA4BAB18AEF));
  }
  public ref CUtlSymbolLarge LerpTargetAttachment {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x42FE8EA4C1E312BC));
  }
  public IAttachmentHandle_t LerpTargetAttachment {
    get => new AttachmentHandle_t(_Handle + Schema.GetOffset(0x42FE8EA4FC3162AA));
  }
  public ref float LerpDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x42FE8EA4B5F8D70A));
  }
  public ref bool LerpRestoreMoveType {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42FE8EA4C501C93F));
  }
  public ref bool SingleLerpObject {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42FE8EA4EC72477B));
  }
  public ref CUtlVector< lerpdata_t > LerpingObjects {
    get => ref _Handle.AsRef<CUtlVector< lerpdata_t >>(Schema.GetOffset(0x42FE8EA40128714C));
  }
  public ref CUtlSymbolLarge LerpEffect {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x42FE8EA4EEECF881));
  }
  public ref CUtlSymbolLarge LerpSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x42FE8EA46CA9EE5F));
  }
  public ref bool AttachTouchingObject {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42FE8EA4569C11D2));
  }
  public ref CHandle< CBaseEntity > EntityToWaitForDisconnect {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x42FE8EA4E8928591));
  }
  public IEntityIOOutput OnLerpStarted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x42FE8EA4AE5EB5AA));
  }
  public IEntityIOOutput OnLerpFinished {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x42FE8EA4FBCC57F7));
  }


}