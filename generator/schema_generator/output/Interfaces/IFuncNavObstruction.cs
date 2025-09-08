using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncNavObstruction : IBaseModelEntity {

  public ref bool Disabled { get; }
  
  public ref bool UseAsyncObstacleUpdate { get; }
  
}