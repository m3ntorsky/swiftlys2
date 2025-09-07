using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBlood : CPointEntity, IBlood {

  public CBlood(nint handle) : base(handle) {
  }

  public CBlood(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref QAngle SprayAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x68CF460A2BDF444E));
  }
  public ref Vector SprayDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x68CF460A0A8A2531));
  }
  public ref float Amount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x68CF460A187D1B1B));
  }
  public ref BloodType Color {
    get => ref _Handle.AsRef<BloodType>(Schema.GetOffset(0x68CF460AD7D017D8));
  }


}