
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgIncrementKillCountAttributeImpl : TypedProtobuf<CMsgIncrementKillCountAttribute>, CMsgIncrementKillCountAttribute
{
  public CMsgIncrementKillCountAttributeImpl(nint handle): base(handle)
  {
  }


  public int KillerAccountId
  { get => Accessor.GetInt32("killer_account_id"); set => Accessor.SetInt32("killer_account_id", value); }


  public int VictimAccountId
  { get => Accessor.GetInt32("victim_account_id"); set => Accessor.SetInt32("victim_account_id", value); }


  public ulong ItemId
  { get => Accessor.GetUInt64("item_id"); set => Accessor.SetUInt64("item_id", value); }


  public uint EventType
  { get => Accessor.GetUInt32("event_type"); set => Accessor.SetUInt32("event_type", value); }


  public uint Amount
  { get => Accessor.GetUInt32("amount"); set => Accessor.SetUInt32("amount", value); }

}
