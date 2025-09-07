using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGameModeRules_ArmsRace : CCSGameModeRules, ICSGameModeRules_ArmsRace {

  public CCSGameModeRules_ArmsRace(nint handle) : base(handle) {
  }

  public CCSGameModeRules_ArmsRace(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CUtlString > WeaponSequence {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xDFFFC2FB1426444C));
  }

  public void WeaponSequenceUpdated() {
    Schema.Update(_Handle, 0xDFFFC2FB1426444C);
  }
}