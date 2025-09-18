
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgGCUpdateSessionIPImpl : TypedProtobuf<CMsgGCUpdateSessionIP>, CMsgGCUpdateSessionIP
{
  public CMsgGCUpdateSessionIPImpl(nint handle): base(handle)
  {
  }


  public ulong Steamid
  { get => Accessor.GetUInt64("steamid"); set => Accessor.SetUInt64("steamid", value); }


  public int Ip
  { get => Accessor.GetInt32("ip"); set => Accessor.SetInt32("ip", value); }

}
