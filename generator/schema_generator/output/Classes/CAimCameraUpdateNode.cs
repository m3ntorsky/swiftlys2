using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAimCameraUpdateNode : CUnaryUpdateNode, IAimCameraUpdateNode {

  public CAimCameraUpdateNode(nint handle) : base(handle) {
  }

  public IAnimParamHandle ParameterPosition {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D01DA71CD41));
  }
  public IAnimParamHandle ParameterOrientation {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D011320E9C8));
  }
  public IAnimParamHandle ParameterSpineRotationWeight {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D013A4DC0C7));
  }
  public IAnimParamHandle ParameterPelvisOffset {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D01C4C67FA8));
  }
  public IAnimParamHandle ParameterUseIK {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D01C8F88C49));
  }
  public IAnimParamHandle ParameterCameraOnly {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D013A129627));
  }
  public IAnimParamHandle ParameterWeaponDepenetrationDistance {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D01316BB0BD));
  }
  public IAnimParamHandle ParameterWeaponDepenetrationDelta {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D01D6C8CDF0));
  }
  public IAnimParamHandle ParameterCameraClearanceDistance {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xE8DD6D01F4F2C992));
  }
  public IAimCameraOpFixedSettings_t OpFixedSettings {
    get => new AimCameraOpFixedSettings_t(_Handle + Schema.GetOffset(0xE8DD6D01E533AB09));
  }


}