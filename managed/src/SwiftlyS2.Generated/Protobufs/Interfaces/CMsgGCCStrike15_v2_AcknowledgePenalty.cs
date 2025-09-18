
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_AcknowledgePenalty : ITypedProtobuf<CMsgGCCStrike15_v2_AcknowledgePenalty>
{
  static CMsgGCCStrike15_v2_AcknowledgePenalty ITypedProtobuf<CMsgGCCStrike15_v2_AcknowledgePenalty>.Wrap(nint handle) => new CMsgGCCStrike15_v2_AcknowledgePenaltyImpl(handle);


  public int Acknowledged { get; set; }

}
