
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageServerFrameTime : ITypedProtobuf<CUserMessageServerFrameTime>, INetMessage<CUserMessageServerFrameTime>
{
  static int INetMessage<CUserMessageServerFrameTime>.MessageId => 154;
  
  static string INetMessage<CUserMessageServerFrameTime>.MessageName => "CUserMessageServerFrameTime";

  static CUserMessageServerFrameTime ITypedProtobuf<CUserMessageServerFrameTime>.Wrap(nint handle) => new CUserMessageServerFrameTimeImpl(handle);


  public float FrameTime { get; set; }

}
