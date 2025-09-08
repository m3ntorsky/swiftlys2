using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysWheelConstraint : CPhysConstraint, IPhysWheelConstraint {

  public CPhysWheelConstraint(nint handle) : base(handle) {
  }

  public ref float SuspensionFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C29D467E68));
  }
  public ref float SuspensionDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C2C2F8EAE3));
  }
  public ref float SuspensionHeightOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C2B6CA3042));
  }
  public ref bool EnableSuspensionLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x597D72C2B8A9BDC2));
  }
  public ref float MinSuspensionOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C2B94341AB));
  }
  public ref float MaxSuspensionOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C22EABFDE9));
  }
  public ref bool EnableSteeringLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x597D72C25B75B454));
  }
  public ref float MinSteeringAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C230EFC46D));
  }
  public ref float MaxSteeringAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C2BA43F487));
  }
  public ref float SteeringAxisFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C24D13EF6B));
  }
  public ref float SpinAxisFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x597D72C266B468FC));
  }
  public ref CHandle<CBaseEntity> SteeringMimicsEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x597D72C2CD5E886D));
  }


}