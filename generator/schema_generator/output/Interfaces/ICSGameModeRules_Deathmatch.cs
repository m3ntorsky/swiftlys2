using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSGameModeRules_Deathmatch : ICSGameModeRules {

  
  public IGameTime_t DMBonusStartTime { get; }
  
  public ref float DMBonusTimeLength { get; }
  
  public ref CUtlString DMBonusWeapon { get; }
}