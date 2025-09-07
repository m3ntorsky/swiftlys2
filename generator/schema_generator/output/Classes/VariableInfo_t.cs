using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VariableInfo_t : SchemaClass, IVariableInfo_t {

  public VariableInfo_t(nint handle) : base(handle) {
  }

  public VariableInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xED8F756E4D8F5786));
  }
  public ref CUtlStringToken NameToken {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0xED8F756E9293FEF3));
  }
  public IFuseVariableIndex_t Index {
    get => new FuseVariableIndex_t(_Handle + Schema.GetOffset(0xED8F756EB73DBE67));
  }
  public ref byte NumComponents {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xED8F756EC5454F4B));
  }
  public ref FuseVariableType_t VarType {
    get => ref _Handle.AsRef<FuseVariableType_t>(Schema.GetOffset(0xED8F756E3AC34F99));
  }
  public ref FuseVariableAccess_t Access {
    get => ref _Handle.AsRef<FuseVariableAccess_t>(Schema.GetOffset(0xED8F756E73907152));
  }


}