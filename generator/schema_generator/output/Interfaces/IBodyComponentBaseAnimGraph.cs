using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBodyComponentBaseAnimGraph : IBodyComponentSkeletonInstance {

  public IBaseAnimGraphController AnimationController { get; }
  
}