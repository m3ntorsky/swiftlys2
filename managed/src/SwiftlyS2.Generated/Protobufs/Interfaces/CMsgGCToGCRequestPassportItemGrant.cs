
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCToGCRequestPassportItemGrant : ITypedProtobuf<CMsgGCToGCRequestPassportItemGrant>
{
  static CMsgGCToGCRequestPassportItemGrant ITypedProtobuf<CMsgGCToGCRequestPassportItemGrant>.Wrap(nint handle) => new CMsgGCToGCRequestPassportItemGrantImpl(handle);


  public ulong SteamId { get; set; }


  public uint LeagueId { get; set; }


  public int RewardFlag { get; set; }

}
