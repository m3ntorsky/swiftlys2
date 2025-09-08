using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_TeamPreviewCharacterPosition : CBaseEntity, ICSGO_TeamPreviewCharacterPosition {

  public CCSGO_TeamPreviewCharacterPosition(nint handle) : base(handle) {
  }



  public void VariantUpdated() {
    Schema.Update(_Handle, 0x58B5CA36B2DB2B42);
  }
  public void RandomUpdated() {
    Schema.Update(_Handle, 0x58B5CA36850EF8CE);
  }
  public void OrdinalUpdated() {
    Schema.Update(_Handle, 0x58B5CA364ABADF96);
  }
  public void WeaponNameUpdated() {
    Schema.Update(_Handle, 0x58B5CA3652FE8889);
  }
  public void XuidUpdated() {
    Schema.Update(_Handle, 0x58B5CA36C61EB42B);
  }
  public void AgentItemUpdated() {
    Schema.Update(_Handle, 0x58B5CA366B625605);
  }
  public void GlovesItemUpdated() {
    Schema.Update(_Handle, 0x58B5CA3692931DD0);
  }
  public void WeaponItemUpdated() {
    Schema.Update(_Handle, 0x58B5CA3689437C5A);
  }
}