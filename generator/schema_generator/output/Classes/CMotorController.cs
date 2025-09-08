using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotorController : SchemaClass, IMotorController {

  public CMotorController(nint handle) : base(handle) {
  }

  public ref float Speed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A8B9067A4BD35A0));
  }
  public ref float MaxTorque {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A8B90677880BF37));
  }
  public ref Vector Axis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A8B90672B06DE94));
  }
  public ref float InertiaFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A8B9067B824C94A));
  }


}