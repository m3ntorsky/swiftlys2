using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerController_InGameMoneyServices : IPlayerControllerComponent {

  public ref bool ReceivesMoneyNextRound { get; }
  
  public ref int MoneyEarnedForNextRound { get; }
  
  public ref int Account { get; }
  
  public ref int StartAccount { get; }
  
  public ref int TotalCashSpent { get; }
  
  public ref int CashSpentThisRound { get; }
  
}