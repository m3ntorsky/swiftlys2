using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CKnife : CCSWeaponBase, IKnife {

  public CKnife(nint handle) : base(handle) {
  }



  public void FirstAttackUpdated() {
    Schema.Update(_Handle, 0x2551A83B441D83D9);
  }
}