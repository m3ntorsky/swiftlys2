using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicAchievement : ILogicalEntity {

  
  public ref bool Disabled { get; }
  
  public ISchemaUntypedField AchievementEventID { get; }
  
  public IEntityIOOutput OnFired { get; }
}