using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnHullDesc_t : RnShapeDesc_t, IRnHullDesc_t {

  public RnHullDesc_t(nint handle) : base(handle) {
  }

  public IRnHull_t Hull {
    get => new RnHull_t(_Handle + Schema.GetOffset(0xBB74EDD8AC535D36));
  }


}