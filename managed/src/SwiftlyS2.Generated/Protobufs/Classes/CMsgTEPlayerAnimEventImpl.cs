
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgTEPlayerAnimEventImpl : NetMessage<CMsgTEPlayerAnimEvent>, CMsgTEPlayerAnimEvent
{
  public CMsgTEPlayerAnimEventImpl(nint handle): base(handle)
  {
  }


  public int Player
  { get => Accessor.GetInt32("player"); set => Accessor.SetInt32("player", value); }


  public uint Event
  { get => Accessor.GetUInt32("event"); set => Accessor.SetUInt32("event", value); }


  public int Data
  { get => Accessor.GetInt32("data"); set => Accessor.SetInt32("data", value); }

}
