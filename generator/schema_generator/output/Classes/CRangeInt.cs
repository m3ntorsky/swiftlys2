using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRangeInt : SchemaClass, IRangeInt {

  public CRangeInt(nint handle) : base(handle) {
  }

  public CRangeInt(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<int32> Value {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0xF42199F07F437844));
  }


}