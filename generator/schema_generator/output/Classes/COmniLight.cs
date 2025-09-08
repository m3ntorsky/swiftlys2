using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class COmniLight : CBarnLight, IOmniLight {

  public COmniLight(nint handle) : base(handle) {
  }



  public void InnerAngleUpdated() {
    Schema.Update(_Handle, 0x46F0D2E5142C32F4);
  }
  public void OuterAngleUpdated() {
    Schema.Update(_Handle, 0x46F0D2E5ECB8B519);
  }
  public void ShowLightUpdated() {
    Schema.Update(_Handle, 0x46F0D2E5D67BC720);
  }
}