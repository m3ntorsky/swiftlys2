using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameMoney : IRulePointEntity {

  public IEntityIOOutput OnMoneySpent { get; }
  
  public IEntityIOOutput OnMoneySpentFail { get; }
  
  public ref int Money { get; }
  
  public ref CUtlString StrAwardText { get; }
  
}