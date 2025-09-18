
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_ClientDeepStats_DeepStatsMatch : ITypedProtobuf<CMsgGCCStrike15_ClientDeepStats_DeepStatsMatch>
{
  static CMsgGCCStrike15_ClientDeepStats_DeepStatsMatch ITypedProtobuf<CMsgGCCStrike15_ClientDeepStats_DeepStatsMatch>.Wrap(nint handle) => new CMsgGCCStrike15_ClientDeepStats_DeepStatsMatchImpl(handle);


  public DeepPlayerStatsEntry Player { get; }


  public IProtobufRepeatedFieldSubMessageType<DeepPlayerMatchEvent> Events { get; }

}
