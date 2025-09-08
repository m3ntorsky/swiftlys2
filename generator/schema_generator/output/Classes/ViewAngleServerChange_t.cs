using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ViewAngleServerChange_t : SchemaClass, IViewAngleServerChange_t {

  public ViewAngleServerChange_t(nint handle) : base(handle) {
  }



  public void TypeUpdated() {
    Schema.Update(_Handle, 0x84AFC64BEEF036F9);
  }
  public void AngleUpdated() {
    Schema.Update(_Handle, 0x84AFC64B64F7DFC7);
  }
  public void IndexUpdated() {
    Schema.Update(_Handle, 0x84AFC64BA1A45087);
  }
}