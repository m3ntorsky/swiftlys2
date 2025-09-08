using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsPropRespawnable : CPhysicsProp, IPhysicsPropRespawnable {

  public CPhysicsPropRespawnable(nint handle) : base(handle) {
  }

  public ref Vector OriginalSpawnOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6C5980BAB6F410AF));
  }
  public ref QAngle OriginalSpawnAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x6C5980BAF7A16BD1));
  }
  public ref Vector OriginalMins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6C5980BAFBA3B1D3));
  }
  public ref Vector OriginalMaxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6C5980BAA4FDD991));
  }
  public ref float RespawnDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6C5980BA476C78ED));
  }


}