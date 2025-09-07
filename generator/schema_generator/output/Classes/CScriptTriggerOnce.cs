using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptTriggerOnce : CTriggerOnce, IScriptTriggerOnce {

  public CScriptTriggerOnce(nint handle) : base(handle) {
  }

  public CScriptTriggerOnce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Extent {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9714EBBA7AB1ED15));
  }


}