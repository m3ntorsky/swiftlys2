using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ScriptInfo_t : SchemaClass, IScriptInfo_t {

  public ScriptInfo_t(nint handle) : base(handle) {
  }

  public ScriptInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Code {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDB402399B70C9D94));
  }
  public ref CUtlVector< CAnimParamHandle > ParamsModified {
    get => ref _Handle.AsRef<CUtlVector< CAnimParamHandle >>(Schema.GetOffset(0xDB402399E9EAFC30));
  }
  public ref CUtlVector< int32 > ProxyReadParams {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0xDB40239944FCCB9D));
  }
  public ref CUtlVector< int32 > ProxyWriteParams {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0xDB4023993EAFD134));
  }
  public ref AnimScriptType ScriptType {
    get => ref _Handle.AsRef<AnimScriptType>(Schema.GetOffset(0xDB40239949576EFB));
  }


}