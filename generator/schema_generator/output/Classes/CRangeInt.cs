using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRangeInt : SchemaClass, IRangeInt {

  public CRangeInt(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<int> Value {
    get => new SchemaFixedArray<int>(_Handle, 0xF42199F07F437844, 2, 4, 4);
  }


}