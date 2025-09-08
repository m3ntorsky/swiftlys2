using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoVisibilityBox : CBaseEntity, IInfoVisibilityBox {

  public CInfoVisibilityBox(nint handle) : base(handle) {
  }



  public void ModeUpdated() {
    Schema.Update(_Handle, 0xD226824F137F1E0E);
  }
  public void BoxSizeUpdated() {
    Schema.Update(_Handle, 0xD226824FE553E487);
  }
  public void EnabledUpdated() {
    Schema.Update(_Handle, 0xD226824F6154EB7E);
  }
}