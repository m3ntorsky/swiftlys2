
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgKickFromParty : ITypedProtobuf<CMsgKickFromParty>
{
  static CMsgKickFromParty ITypedProtobuf<CMsgKickFromParty>.Wrap(nint handle) => new CMsgKickFromPartyImpl(handle);


  public ulong SteamId { get; set; }

}
