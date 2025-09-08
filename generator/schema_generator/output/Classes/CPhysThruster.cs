using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysThruster : CPhysForce, IPhysThruster {

  public CPhysThruster(nint handle) : base(handle) {
  }

  public ref Vector LocalOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC6E190F75672584A));
  }


}