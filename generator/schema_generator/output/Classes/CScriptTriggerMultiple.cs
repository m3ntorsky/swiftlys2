using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptTriggerMultiple : CTriggerMultiple, IScriptTriggerMultiple {

  public CScriptTriggerMultiple(nint handle) : base(handle) {
  }

  public ref Vector Extent {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE1F82C9B7AB1ED15));
  }


}