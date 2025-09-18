
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgVDebugGameSessionIDEvent : ITypedProtobuf<CMsgVDebugGameSessionIDEvent>, INetMessage<CMsgVDebugGameSessionIDEvent>
{
  static int INetMessage<CMsgVDebugGameSessionIDEvent>.MessageId => 200;
  
  static string INetMessage<CMsgVDebugGameSessionIDEvent>.MessageName => "CMsgVDebugGameSessionIDEvent";

  static CMsgVDebugGameSessionIDEvent ITypedProtobuf<CMsgVDebugGameSessionIDEvent>.Wrap(nint handle) => new CMsgVDebugGameSessionIDEventImpl(handle);


  public int Clientid { get; set; }


  public string Gamesessionid { get; set; }

}
