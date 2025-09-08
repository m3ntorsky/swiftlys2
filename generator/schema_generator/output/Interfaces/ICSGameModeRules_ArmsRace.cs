using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSGameModeRules_ArmsRace : ICSGameModeRules {

  public ref CUtlVector<CUtlString> WeaponSequence { get; }
  
}