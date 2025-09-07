using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerSave : CBaseTrigger, ITriggerSave {

  public CTriggerSave(nint handle) : base(handle) {
  }

  public CTriggerSave(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool ForceNewLevelUnit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFA0C03F1473BFDE));
  }
  public ref float DangerousTimer {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFA0C03F5CF80EC4));
  }
  public ref int MinHitPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xFA0C03F2C7E0C57));
  }


}