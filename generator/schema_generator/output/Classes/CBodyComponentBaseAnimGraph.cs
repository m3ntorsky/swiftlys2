using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyComponentBaseAnimGraph : CBodyComponentSkeletonInstance, IBodyComponentBaseAnimGraph {

  public CBodyComponentBaseAnimGraph(nint handle) : base(handle) {
  }

  public CBodyComponentBaseAnimGraph(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IBaseAnimGraphController AnimationController {
    get => new CBaseAnimGraphController(_Handle + Schema.GetOffset(0xD004A34F552AD749));
  }

  public void AnimationControllerUpdated() {
    Schema.Update(_Handle, 0xD004A34F552AD749);
  }
}