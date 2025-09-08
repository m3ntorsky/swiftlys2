using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ServerAuthoritativeWeaponSlot_t : SchemaClass, IServerAuthoritativeWeaponSlot_t {

  public ServerAuthoritativeWeaponSlot_t(nint handle) : base(handle) {
  }



  public void ClassUpdated() {
    Schema.Update(_Handle, 0x8AF3F5CAECD2A54A);
  }
  public void SlotUpdated() {
    Schema.Update(_Handle, 0x8AF3F5CAF5443C5E);
  }
  public void ItemDefIdxUpdated() {
    Schema.Update(_Handle, 0x8AF3F5CA7BE26777);
  }
}