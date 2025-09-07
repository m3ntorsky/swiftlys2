using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimScriptManager : SchemaClass, IAnimScriptManager {

  public CAnimScriptManager(nint handle) : base(handle) {
  }

  public CAnimScriptManager(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< ScriptInfo_t > ScriptInfo {
    get => ref _Handle.AsRef<CUtlVector< ScriptInfo_t >>(Schema.GetOffset(0x13962EC3119509F2));
  }


}