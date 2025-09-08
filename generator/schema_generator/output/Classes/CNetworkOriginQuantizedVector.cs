using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNetworkOriginQuantizedVector : SchemaClass, INetworkOriginQuantizedVector {

  public CNetworkOriginQuantizedVector(nint handle) : base(handle) {
  }



  public void XUpdated() {
    Schema.Update(_Handle, 0xB34626888FEB7867);
  }
  public void YUpdated() {
    Schema.Update(_Handle, 0xB34626888EEB76D4);
  }
  public void ZUpdated() {
    Schema.Update(_Handle, 0xB346268891EB7B8D);
  }
}