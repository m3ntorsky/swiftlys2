using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponBaseItem : CCSWeaponBase, IWeaponBaseItem {

  public CWeaponBaseItem(nint handle) : base(handle) {
  }



  public void SequenceInProgressUpdated() {
    Schema.Update(_Handle, 0xE4ECC3486DDA8858);
  }
  public void RedrawUpdated() {
    Schema.Update(_Handle, 0xE4ECC348612F4EB2);
  }
}