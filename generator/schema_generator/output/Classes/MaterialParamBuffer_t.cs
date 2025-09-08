using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialParamBuffer_t : MaterialParam_t, IMaterialParamBuffer_t {

  public MaterialParamBuffer_t(nint handle) : base(handle) {
  }

  public ref CUtlBinaryBlock Value {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0x90FFBDB46B99AEEA));
  }


}