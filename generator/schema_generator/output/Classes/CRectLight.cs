using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRectLight : CBarnLight, IRectLight {

  public CRectLight(nint handle) : base(handle) {
  }



  public void ShowLightUpdated() {
    Schema.Update(_Handle, 0xF5C5D1F4D67BC720);
  }
}