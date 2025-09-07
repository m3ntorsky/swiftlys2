using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnCapsuleDesc_t : RnShapeDesc_t, IRnCapsuleDesc_t {

  public RnCapsuleDesc_t(nint handle) : base(handle) {
  }

  public RnCapsuleDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IRnCapsule_t Capsule {
    get => new RnCapsule_t(_Handle + Schema.GetOffset(0x842345E29A32484C));
  }


}