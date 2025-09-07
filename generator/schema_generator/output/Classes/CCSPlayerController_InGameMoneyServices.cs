using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerController_InGameMoneyServices : CPlayerControllerComponent, ICSPlayerController_InGameMoneyServices {

  public CCSPlayerController_InGameMoneyServices(nint handle) : base(handle) {
  }

  public CCSPlayerController_InGameMoneyServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool ReceivesMoneyNextRound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6C87CBFDB54DB07C));
  }
  public ref int MoneyEarnedForNextRound {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6C87CBFDAB17AAC1));
  }
  public ref int Account {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6C87CBFDF7F4E98B));
  }
  public ref int StartAccount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6C87CBFD6433FAB7));
  }
  public ref int TotalCashSpent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6C87CBFDD4977327));
  }
  public ref int CashSpentThisRound {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6C87CBFDFB4284AB));
  }

  public void AccountUpdated() {
    Schema.Update(_Handle, 0x6C87CBFDF7F4E98B);
  }
  public void StartAccountUpdated() {
    Schema.Update(_Handle, 0x6C87CBFD6433FAB7);
  }
  public void TotalCashSpentUpdated() {
    Schema.Update(_Handle, 0x6C87CBFDD4977327);
  }
  public void CashSpentThisRoundUpdated() {
    Schema.Update(_Handle, 0x6C87CBFDFB4284AB);
  }
}