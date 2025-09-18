
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_MatchmakingStop : ITypedProtobuf<CMsgGCCStrike15_v2_MatchmakingStop>
{
  static CMsgGCCStrike15_v2_MatchmakingStop ITypedProtobuf<CMsgGCCStrike15_v2_MatchmakingStop>.Wrap(nint handle) => new CMsgGCCStrike15_v2_MatchmakingStopImpl(handle);


  public int Abandon { get; set; }

}
