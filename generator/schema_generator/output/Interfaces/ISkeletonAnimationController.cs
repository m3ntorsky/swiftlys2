using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonAnimationController : IISkeletonAnimationController {

  
  public ISkeletonInstance SkeletonInstance { get; }
}