using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyComponentPoint : CBodyComponent, IBodyComponentPoint {

  public CBodyComponentPoint(nint handle) : base(handle) {
  }

  public CBodyComponentPoint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameSceneNode SceneNode {
    get => new CGameSceneNode(_Handle + Schema.GetOffset(0x21A4C11041577E3));
  }

  public void SceneNodeUpdated() {
    Schema.Update(_Handle, 0x21A4C11041577E3);
  }
}