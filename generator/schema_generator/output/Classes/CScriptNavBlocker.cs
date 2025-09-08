using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptNavBlocker : CFuncNavBlocker, IScriptNavBlocker {

  public CScriptNavBlocker(nint handle) : base(handle) {
  }

  public ref Vector Extent {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x50903EB87AB1ED15));
  }


}