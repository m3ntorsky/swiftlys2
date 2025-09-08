using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AimCameraOpFixedSettings_t : SchemaClass, IAimCameraOpFixedSettings_t {

  public AimCameraOpFixedSettings_t(nint handle) : base(handle) {
  }

  public ref int ChainIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA3971F52A34589B6));
  }
  public ref int CameraJointIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA3971F52346981DA));
  }
  public ref int PelvisJointIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA3971F52800F5FB4));
  }
  public ref int ClavicleLeftJointIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA3971F5207F7ABDB));
  }
  public ref int ClavicleRightJointIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA3971F522F2C40A4));
  }
  public ref int DepenetrationJointIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA3971F526307286F));
  }
  public ref CUtlVector<int> PropJoints {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0xA3971F5224880565));
  }


}