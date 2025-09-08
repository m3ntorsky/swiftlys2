using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyComponentSkeletonInstance : CBodyComponent, IBodyComponentSkeletonInstance {

  public CBodyComponentSkeletonInstance(nint handle) : base(handle) {
  }



  public void SkeletonInstanceUpdated() {
    Schema.Update(_Handle, 0x4581C459228537B9);
  }
}