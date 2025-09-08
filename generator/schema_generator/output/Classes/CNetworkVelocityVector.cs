using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNetworkVelocityVector : SchemaClass, INetworkVelocityVector {

  public CNetworkVelocityVector(nint handle) : base(handle) {
  }



  public void XUpdated() {
    Schema.Update(_Handle, 0x63CDAFC08FEB7867);
  }
  public void YUpdated() {
    Schema.Update(_Handle, 0x63CDAFC08EEB76D4);
  }
  public void ZUpdated() {
    Schema.Update(_Handle, 0x63CDAFC091EB7B8D);
  }
}