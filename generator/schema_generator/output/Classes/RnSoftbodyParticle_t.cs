using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnSoftbodyParticle_t : SchemaClass, IRnSoftbodyParticle_t {

  public RnSoftbodyParticle_t(nint handle) : base(handle) {
  }

  public RnSoftbodyParticle_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MassInv {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFC49E2986218E3D2));
  }


}