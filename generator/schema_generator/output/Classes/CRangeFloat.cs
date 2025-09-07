using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRangeFloat : SchemaClass, IRangeFloat {

  public CRangeFloat(nint handle) : base(handle) {
  }

  public CRangeFloat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<float32> Value {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0xD3CD83EB7F437844));
  }


}