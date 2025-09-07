using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGameModeRules_Deathmatch : CCSGameModeRules, ICSGameModeRules_Deathmatch {

  public CCSGameModeRules_Deathmatch(nint handle) : base(handle) {
  }

  public CCSGameModeRules_Deathmatch(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t DMBonusStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x77BC0D42870B2CD0));
  }
  public ref float DMBonusTimeLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x77BC0D42C4F13CC6));
  }
  public ref CUtlString DMBonusWeapon {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x77BC0D42A33FC260));
  }

  public void DMBonusStartTimeUpdated() {
    Schema.Update(_Handle, 0x77BC0D42870B2CD0);
  }
  public void DMBonusTimeLengthUpdated() {
    Schema.Update(_Handle, 0x77BC0D42C4F13CC6);
  }
  public void DMBonusWeaponUpdated() {
    Schema.Update(_Handle, 0x77BC0D42A33FC260);
  }
}