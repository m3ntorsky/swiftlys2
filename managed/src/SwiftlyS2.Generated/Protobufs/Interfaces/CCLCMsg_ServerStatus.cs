
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCLCMsg_ServerStatus : ITypedProtobuf<CCLCMsg_ServerStatus>, INetMessage<CCLCMsg_ServerStatus>
{
  static int INetMessage<CCLCMsg_ServerStatus>.MessageId => 31;
  
  static string INetMessage<CCLCMsg_ServerStatus>.MessageName => "CCLCMsg_ServerStatus";

  static CCLCMsg_ServerStatus ITypedProtobuf<CCLCMsg_ServerStatus>.Wrap(nint handle) => new CCLCMsg_ServerStatusImpl(handle);


  public bool Simplified { get; set; }

}
