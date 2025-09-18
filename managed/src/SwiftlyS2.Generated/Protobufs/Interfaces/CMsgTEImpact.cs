
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEImpact : ITypedProtobuf<CMsgTEImpact>, INetMessage<CMsgTEImpact>
{
  static int INetMessage<CMsgTEImpact>.MessageId => 416;
  
  static string INetMessage<CMsgTEImpact>.MessageName => "CMsgTEImpact";

  static CMsgTEImpact ITypedProtobuf<CMsgTEImpact>.Wrap(nint handle) => new CMsgTEImpactImpl(handle);


  public Vector Origin { get; set; }


  public Vector Normal { get; set; }


  public uint Type { get; set; }

}
