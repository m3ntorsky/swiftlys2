using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundAreaEntityOrientedBox : CSoundAreaEntityBase, ISoundAreaEntityOrientedBox {

  public CSoundAreaEntityOrientedBox(nint handle) : base(handle) {
  }



  public void MinUpdated() {
    Schema.Update(_Handle, 0x5D327060F4B0AA63);
  }
  public void MaxUpdated() {
    Schema.Update(_Handle, 0x5D327060EAC4225D);
  }
}