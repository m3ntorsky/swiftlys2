using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptTriggerPush : CTriggerPush, IScriptTriggerPush {

  public CScriptTriggerPush(nint handle) : base(handle) {
  }

  public ref Vector Extent {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x22B0DC1B7AB1ED15));
  }


}