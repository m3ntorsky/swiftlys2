using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SoundeventPathCornerPairNetworked_t : SchemaClass, ISoundeventPathCornerPairNetworked_t {

  public SoundeventPathCornerPairNetworked_t(nint handle) : base(handle) {
  }



  public void P1Updated() {
    Schema.Update(_Handle, 0x138FC2E2CD01805E);
  }
  public void P2Updated() {
    Schema.Update(_Handle, 0x138FC2E2CC017ECB);
  }
  public void PathLengthSqrUpdated() {
    Schema.Update(_Handle, 0x138FC2E284D826AA);
  }
  public void P1PctUpdated() {
    Schema.Update(_Handle, 0x138FC2E258AEE12B);
  }
  public void P2PctUpdated() {
    Schema.Update(_Handle, 0x138FC2E294B6CBA8);
  }
}