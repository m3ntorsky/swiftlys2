using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerActiveWeaponDetect : CBaseTrigger, ITriggerActiveWeaponDetect {

  public CTriggerActiveWeaponDetect(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnTouchedActiveWeapon {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x68F50CC727D5D394));
  }
  public ref CUtlSymbolLarge WeaponClassName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x68F50CC7BD3D5B08));
  }


}