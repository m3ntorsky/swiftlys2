using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeTreeChildren_t : SchemaClass, IFeTreeChildren_t {

  public FeTreeChildren_t(nint handle) : base(handle) {
  }

  public FeTreeChildren_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Child {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0xD4BAF4A0E8CD59A1));
  }


}