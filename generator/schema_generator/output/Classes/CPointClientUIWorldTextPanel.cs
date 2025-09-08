using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointClientUIWorldTextPanel : CPointClientUIWorldPanel, IPointClientUIWorldTextPanel {

  public CPointClientUIWorldTextPanel(nint handle) : base(handle) {
  }



  public void MessageTextUpdated() {
    Schema.Update(_Handle, 0x9F10465EBA6E5D73);
  }
}