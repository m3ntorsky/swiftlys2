using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIKJoint : SchemaClass, INmIKJoint {

  public CNmIKJoint(nint handle) : base(handle) {
  }

  public ref int ParentIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x31287449134E2DE7));
  }
  public ref int BodyIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x312874492B50B497));
  }
  public ref CTransform XLocalFrame {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x31287449AD5CD897));
  }
  public ref float SwingLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x31287449279A44C2));
  }
  public ref float MinTwistLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3128744914A803B7));
  }
  public ref float MaxTwistLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x31287449F1241F7D));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x312874497B81E7AB));
  }


}