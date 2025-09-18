
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_WarmupHasEnded : ITypedProtobuf<CCSUsrMsg_WarmupHasEnded>, INetMessage<CCSUsrMsg_WarmupHasEnded>
{
  static int INetMessage<CCSUsrMsg_WarmupHasEnded>.MessageId => 338;
  
  static string INetMessage<CCSUsrMsg_WarmupHasEnded>.MessageName => "CCSUsrMsg_WarmupHasEnded";

  static CCSUsrMsg_WarmupHasEnded ITypedProtobuf<CCSUsrMsg_WarmupHasEnded>.Wrap(nint handle) => new CCSUsrMsg_WarmupHasEndedImpl(handle);


  public int Dummy { get; set; }

}
