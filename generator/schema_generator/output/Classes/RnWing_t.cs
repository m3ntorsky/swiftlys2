using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnWing_t : SchemaClass, IRnWing_t {

  public RnWing_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<int> Index {
    get => new SchemaFixedArray<int>(_Handle, 0xED8A9D45B73DBE67, 3, 4, 4);
  }


}