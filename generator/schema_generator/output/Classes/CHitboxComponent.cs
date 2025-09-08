using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHitboxComponent : CEntityComponent, IHitboxComponent {

  public CHitboxComponent(nint handle) : base(handle) {
  }



  public void DisabledHitGroupsUpdated() {
    Schema.Update(_Handle, 0x8148DEC3DDB01736);
  }
}