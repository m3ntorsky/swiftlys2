using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundAreaEntitySphere : CSoundAreaEntityBase, ISoundAreaEntitySphere {

  public CSoundAreaEntitySphere(nint handle) : base(handle) {
  }



  public void RadiusUpdated() {
    Schema.Update(_Handle, 0x2FF7C1D65ACFC08D);
  }
}