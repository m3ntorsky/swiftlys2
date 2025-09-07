using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ModelConfigHandle_t : SchemaClass, IModelConfigHandle_t {

  public ModelConfigHandle_t(nint handle) : base(handle) {
  }

  public ModelConfigHandle_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint Value {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x5DC9B751DCB0894A));
  }


}