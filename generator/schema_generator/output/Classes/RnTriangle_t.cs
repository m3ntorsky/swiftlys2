using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnTriangle_t : SchemaClass, IRnTriangle_t {

  public RnTriangle_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<int> Index {
    get => new SchemaFixedArray<int>(_Handle, 0x2136F8E2B73DBE67, 3, 4, 4);
  }


}