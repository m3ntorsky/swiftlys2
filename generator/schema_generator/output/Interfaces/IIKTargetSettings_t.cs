using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IIKTargetSettings_t : ISchemaClass {

  
  public ref IKTargetSource TargetSource { get; }
  
  public IIKBoneNameAndIndex_t Bone { get; }
  
  public IAnimParamID AnimgraphParameterNamePosition { get; }
  
  public IAnimParamID AnimgraphParameterNameOrientation { get; }
  
  public ref IKTargetCoordinateSystem TargetCoordSystem { get; }
}