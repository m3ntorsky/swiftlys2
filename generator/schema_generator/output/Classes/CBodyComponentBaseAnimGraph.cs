using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyComponentBaseAnimGraph : CBodyComponentSkeletonInstance, IBodyComponentBaseAnimGraph {

  public CBodyComponentBaseAnimGraph(nint handle) : base(handle) {
  }



  public void AnimationControllerUpdated() {
    Schema.Update(_Handle, 0xD004A34F552AD749);
  }
}