using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ConstantInfo_t : SchemaClass, IConstantInfo_t {

  public ConstantInfo_t(nint handle) : base(handle) {
  }

  public ConstantInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF4BEF78E4D8F5786));
  }
  public ref CUtlStringToken NameToken {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0xF4BEF78E9293FEF3));
  }
  public ref float Value {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF4BEF78E8DFCB984));
  }


}