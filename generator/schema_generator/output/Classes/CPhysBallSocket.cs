using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysBallSocket : CPhysConstraint, IPhysBallSocket {

  public CPhysBallSocket(nint handle) : base(handle) {
  }

  public ref float JointFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE2408965CA9FD47));
  }
  public ref bool EnableSwingLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDE240896DADAC14B));
  }
  public ref float SwingLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE240896279A44C2));
  }
  public ref bool EnableTwistLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDE2408967DBEA570));
  }
  public ref float MinTwistAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE240896B6E6BB7F));
  }
  public ref float MaxTwistAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDE24089690C63AD5));
  }


}