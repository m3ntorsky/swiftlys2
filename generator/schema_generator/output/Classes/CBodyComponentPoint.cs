using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyComponentPoint : CBodyComponent, IBodyComponentPoint {

  public CBodyComponentPoint(nint handle) : base(handle) {
  }



  public void SceneNodeUpdated() {
    Schema.Update(_Handle, 0x21A4C11041577E3);
  }
}