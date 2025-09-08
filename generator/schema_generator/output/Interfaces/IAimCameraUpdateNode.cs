using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAimCameraUpdateNode : IUnaryUpdateNode {

  public IAnimParamHandle ParameterPosition { get; }
  
  public IAnimParamHandle ParameterOrientation { get; }
  
  public IAnimParamHandle ParameterSpineRotationWeight { get; }
  
  public IAnimParamHandle ParameterPelvisOffset { get; }
  
  public IAnimParamHandle ParameterUseIK { get; }
  
  public IAnimParamHandle ParameterCameraOnly { get; }
  
  public IAnimParamHandle ParameterWeaponDepenetrationDistance { get; }
  
  public IAnimParamHandle ParameterWeaponDepenetrationDelta { get; }
  
  public IAnimParamHandle ParameterCameraClearanceDistance { get; }
  
  public IAimCameraOpFixedSettings_t OpFixedSettings { get; }
  
}