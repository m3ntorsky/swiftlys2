using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeTreeChildren_t : SchemaClass, IFeTreeChildren_t {

  public FeTreeChildren_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort> Child {
    get => new SchemaFixedArray<ushort>(_Handle, 0xD4BAF4A0E8CD59A1, 2, 2, 2);
  }


}