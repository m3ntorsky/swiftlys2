
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_MatchStatsUpdate : ITypedProtobuf<CCSUsrMsg_MatchStatsUpdate>, INetMessage<CCSUsrMsg_MatchStatsUpdate>
{
  static int INetMessage<CCSUsrMsg_MatchStatsUpdate>.MessageId => 358;
  
  static string INetMessage<CCSUsrMsg_MatchStatsUpdate>.MessageName => "CCSUsrMsg_MatchStatsUpdate";

  static CCSUsrMsg_MatchStatsUpdate ITypedProtobuf<CCSUsrMsg_MatchStatsUpdate>.Wrap(nint handle) => new CCSUsrMsg_MatchStatsUpdateImpl(handle);


  public string Update { get; set; }

}
