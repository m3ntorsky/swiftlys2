using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnTriangle_t : SchemaClass, IRnTriangle_t {

  public RnTriangle_t(nint handle) : base(handle) {
  }

  public RnTriangle_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<int32> Index {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x2136F8E2B73DBE67));
  }


}