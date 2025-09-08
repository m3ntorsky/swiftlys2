using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAimCameraOpFixedSettings_t : ISchemaClass {

  public ref int ChainIndex { get; }
  
  public ref int CameraJointIndex { get; }
  
  public ref int PelvisJointIndex { get; }
  
  public ref int ClavicleLeftJointIndex { get; }
  
  public ref int ClavicleRightJointIndex { get; }
  
  public ref int DepenetrationJointIndex { get; }
  
  public ref CUtlVector<int> PropJoints { get; }
  
}