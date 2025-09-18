
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEBeamPoints : ITypedProtobuf<CMsgTEBeamPoints>, INetMessage<CMsgTEBeamPoints>
{
  static int INetMessage<CMsgTEBeamPoints>.MessageId => 404;
  
  static string INetMessage<CMsgTEBeamPoints>.MessageName => "CMsgTEBeamPoints";

  static CMsgTEBeamPoints ITypedProtobuf<CMsgTEBeamPoints>.Wrap(nint handle) => new CMsgTEBeamPointsImpl(handle);


  public CMsgTEBaseBeam Base { get; }


  public Vector Start { get; set; }


  public Vector End { get; set; }

}
