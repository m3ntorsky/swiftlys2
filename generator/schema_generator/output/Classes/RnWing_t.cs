using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnWing_t : SchemaClass, IRnWing_t {

  public RnWing_t(nint handle) : base(handle) {
  }

  public RnWing_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<int32> Index {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0xED8A9D45B73DBE67));
  }


}