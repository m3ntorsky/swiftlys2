using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkyCamera : CBaseEntity, ISkyCamera {

  public CSkyCamera(nint handle) : base(handle) {
  }

  public ref bool UseAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCD44EF44434C3DB4));
  }
  public ISkyCamera Next {
    get => new CSkyCamera(_Handle + Schema.GetOffset(0xCD44EF4432B11E0E));
  }

  public void SkyboxDataUpdated() {
    Schema.Update(_Handle, 0xCD44EF44CDA0772B);
  }
  public void SkyboxSlotTokenUpdated() {
    Schema.Update(_Handle, 0xCD44EF44413FD3A4);
  }
}