using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialParamInt_t : MaterialParam_t, IMaterialParamInt_t {

  public MaterialParamInt_t(nint handle) : base(handle) {
  }

  public MaterialParamInt_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD2910839077D337E));
  }


}