using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayerPing : CBaseEntity, IPlayerPing {

  public CPlayerPing(nint handle) : base(handle) {
  }



  public void PlayerUpdated() {
    Schema.Update(_Handle, 0x5943E25F68856C16);
  }
  public void PingedEntityUpdated() {
    Schema.Update(_Handle, 0x5943E25F35D9D429);
  }
  public void TypeUpdated() {
    Schema.Update(_Handle, 0x5943E25FC932D7CC);
  }
  public void UrgentUpdated() {
    Schema.Update(_Handle, 0x5943E25F4F5EE9D0);
  }
  public void PlaceNameUpdated() {
    Schema.Update(_Handle, 0x5943E25F6039F660);
  }
}