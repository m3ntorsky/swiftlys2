using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISolveIKTargetHandle_t : ISchemaClass {

  
  public IAnimParamHandle PositionHandle { get; }
  
  public IAnimParamHandle OrientationHandle { get; }
}