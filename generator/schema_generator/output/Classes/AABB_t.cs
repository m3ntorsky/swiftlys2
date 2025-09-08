using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AABB_t : SchemaClass, IAABB_t {

  public AABB_t(nint handle) : base(handle) {
  }



  public void MinBoundsUpdated() {
    Schema.Update(_Handle, 0xC0D32A84114799FE);
  }
  public void MaxBoundsUpdated() {
    Schema.Update(_Handle, 0xC0D32A84C0B4CE60);
  }
}