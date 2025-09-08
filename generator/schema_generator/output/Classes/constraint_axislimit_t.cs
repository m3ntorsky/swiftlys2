using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class constraint_axislimit_t : SchemaClass, Iconstraint_axislimit_t {

  public constraint_axislimit_t(nint handle) : base(handle) {
  }

  public ref float MinRotation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x610A06522A8C970B));
  }
  public ref float MaxRotation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x610A0652FEB73D49));
  }
  public ref float MotorTargetAngSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x610A0652C783A98E));
  }
  public ref float MotorMaxTorque {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x610A0652808C4A00));
  }


}