using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBodyComponentSkeletonInstance : IBodyComponent {

  public ISkeletonInstance SkeletonInstance { get; }
  
}