
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_VoteFailed : ITypedProtobuf<CCSUsrMsg_VoteFailed>, INetMessage<CCSUsrMsg_VoteFailed>
{
  static int INetMessage<CCSUsrMsg_VoteFailed>.MessageId => 348;
  
  static string INetMessage<CCSUsrMsg_VoteFailed>.MessageName => "CCSUsrMsg_VoteFailed";

  static CCSUsrMsg_VoteFailed ITypedProtobuf<CCSUsrMsg_VoteFailed>.Wrap(nint handle) => new CCSUsrMsg_VoteFailedImpl(handle);


  public int Team { get; set; }


  public int Reason { get; set; }

}
