
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_ClientPartyJoinRelay : ITypedProtobuf<CMsgGCCStrike15_v2_ClientPartyJoinRelay>
{
  static CMsgGCCStrike15_v2_ClientPartyJoinRelay ITypedProtobuf<CMsgGCCStrike15_v2_ClientPartyJoinRelay>.Wrap(nint handle) => new CMsgGCCStrike15_v2_ClientPartyJoinRelayImpl(handle);


  public uint Accountid { get; set; }


  public ulong Lobbyid { get; set; }

}
