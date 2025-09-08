using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicAchievement : ILogicalEntity {

  public ref bool Disabled { get; }
  
  public ref CUtlSymbolLarge AchievementEventID { get; }
  
  public IEntityIOOutput OnFired { get; }
  
}