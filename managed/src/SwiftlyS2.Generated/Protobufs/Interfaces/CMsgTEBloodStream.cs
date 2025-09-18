
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEBloodStream : ITypedProtobuf<CMsgTEBloodStream>, INetMessage<CMsgTEBloodStream>
{
  static int INetMessage<CMsgTEBloodStream>.MessageId => 418;
  
  static string INetMessage<CMsgTEBloodStream>.MessageName => "CMsgTEBloodStream";

  static CMsgTEBloodStream ITypedProtobuf<CMsgTEBloodStream>.Wrap(nint handle) => new CMsgTEBloodStreamImpl(handle);


  public Vector Origin { get; set; }


  public Vector Direction { get; set; }


  public int Color { get; set; }


  public uint Amount { get; set; }

}
