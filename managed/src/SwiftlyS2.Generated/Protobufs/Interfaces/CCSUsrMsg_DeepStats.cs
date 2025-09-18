
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_DeepStats : ITypedProtobuf<CCSUsrMsg_DeepStats>, INetMessage<CCSUsrMsg_DeepStats>
{
  static int INetMessage<CCSUsrMsg_DeepStats>.MessageId => 381;
  
  static string INetMessage<CCSUsrMsg_DeepStats>.MessageName => "CCSUsrMsg_DeepStats";

  static CCSUsrMsg_DeepStats ITypedProtobuf<CCSUsrMsg_DeepStats>.Wrap(nint handle) => new CCSUsrMsg_DeepStatsImpl(handle);


  public CMsgGCCStrike15_ClientDeepStats Stats { get; }

}
