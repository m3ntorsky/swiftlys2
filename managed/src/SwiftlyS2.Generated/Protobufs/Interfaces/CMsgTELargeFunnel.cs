
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTELargeFunnel : ITypedProtobuf<CMsgTELargeFunnel>, INetMessage<CMsgTELargeFunnel>
{
  static int INetMessage<CMsgTELargeFunnel>.MessageId => 421;
  
  static string INetMessage<CMsgTELargeFunnel>.MessageName => "CMsgTELargeFunnel";

  static CMsgTELargeFunnel ITypedProtobuf<CMsgTELargeFunnel>.Wrap(nint handle) => new CMsgTELargeFunnelImpl(handle);


  public Vector Origin { get; set; }


  public uint Reversed { get; set; }

}
