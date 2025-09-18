
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CCSUsrMsg_AdjustMoneyImpl : NetMessage<CCSUsrMsg_AdjustMoney>, CCSUsrMsg_AdjustMoney
{
  public CCSUsrMsg_AdjustMoneyImpl(nint handle): base(handle)
  {
  }


  public int Amount
  { get => Accessor.GetInt32("amount"); set => Accessor.SetInt32("amount", value); }

}
