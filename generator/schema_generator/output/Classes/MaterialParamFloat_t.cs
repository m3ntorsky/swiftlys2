using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialParamFloat_t : MaterialParam_t, IMaterialParamFloat_t {

  public MaterialParamFloat_t(nint handle) : base(handle) {
  }

  public ref float Value {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB6A452E28DFCB984));
  }


}