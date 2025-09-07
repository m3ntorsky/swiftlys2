using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialParamVector_t : MaterialParam_t, IMaterialParamVector_t {

  public MaterialParamVector_t(nint handle) : base(handle) {
  }

  public MaterialParamVector_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector4D Value {
    get => ref _Handle.AsRef<Vector4D>(Schema.GetOffset(0xC82210956B99AEEA));
  }


}