
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCLCMsg_SplitPlayerConnect : ITypedProtobuf<CCLCMsg_SplitPlayerConnect>, INetMessage<CCLCMsg_SplitPlayerConnect>
{
  static int INetMessage<CCLCMsg_SplitPlayerConnect>.MessageId => 28;
  
  static string INetMessage<CCLCMsg_SplitPlayerConnect>.MessageName => "CCLCMsg_SplitPlayerConnect";

  static CCLCMsg_SplitPlayerConnect ITypedProtobuf<CCLCMsg_SplitPlayerConnect>.Wrap(nint handle) => new CCLCMsg_SplitPlayerConnectImpl(handle);


  public string Playername { get; set; }

}
