using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGameModeRules_ArmsRace : CCSGameModeRules, ICSGameModeRules_ArmsRace {

  public CCSGameModeRules_ArmsRace(nint handle) : base(handle) {
  }



  public void WeaponSequenceUpdated() {
    Schema.Update(_Handle, 0xDFFFC2FB1426444C);
  }
}