
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_CallVoteFailed : ITypedProtobuf<CCSUsrMsg_CallVoteFailed>, INetMessage<CCSUsrMsg_CallVoteFailed>
{
  static int INetMessage<CCSUsrMsg_CallVoteFailed>.MessageId => 348;
  
  static string INetMessage<CCSUsrMsg_CallVoteFailed>.MessageName => "CCSUsrMsg_CallVoteFailed";

  static CCSUsrMsg_CallVoteFailed ITypedProtobuf<CCSUsrMsg_CallVoteFailed>.Wrap(nint handle) => new CCSUsrMsg_CallVoteFailedImpl(handle);


  public int Reason { get; set; }


  public int Time { get; set; }

}
