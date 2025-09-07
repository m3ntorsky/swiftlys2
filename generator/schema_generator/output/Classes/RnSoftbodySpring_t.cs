using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnSoftbodySpring_t : SchemaClass, IRnSoftbodySpring_t {

  public RnSoftbodySpring_t(nint handle) : base(handle) {
  }

  public RnSoftbodySpring_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Particle {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0xAB4E9C9B863A8E83));
  }
  public ref float Length {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAB4E9C9BFF9776DF));
  }


}