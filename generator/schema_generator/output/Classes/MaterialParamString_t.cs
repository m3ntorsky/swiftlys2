using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialParamString_t : MaterialParam_t, IMaterialParamString_t {

  public MaterialParamString_t(nint handle) : base(handle) {
  }

  public MaterialParamString_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Value {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDB5EB0676B99AEEA));
  }


}