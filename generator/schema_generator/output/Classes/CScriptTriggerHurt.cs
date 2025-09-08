using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptTriggerHurt : CTriggerHurt, IScriptTriggerHurt {

  public CScriptTriggerHurt(nint handle) : base(handle) {
  }

  public ref Vector Extent {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA813A9867AB1ED15));
  }


}