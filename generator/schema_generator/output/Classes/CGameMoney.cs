using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameMoney : CRulePointEntity, IGameMoney {

  public CGameMoney(nint handle) : base(handle) {
  }

  public CGameMoney(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnMoneySpent {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xED17C684B6CD990C));
  }
  public IEntityIOOutput OnMoneySpentFail {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xED17C684DB165FC0));
  }
  public ref int Money {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xED17C6845BE25D03));
  }
  public ref CUtlString StrAwardText {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xED17C684B48AB662));
  }


}