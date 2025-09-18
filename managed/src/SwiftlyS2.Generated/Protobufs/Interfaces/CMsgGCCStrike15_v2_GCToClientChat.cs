
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_GCToClientChat : ITypedProtobuf<CMsgGCCStrike15_v2_GCToClientChat>
{
  static CMsgGCCStrike15_v2_GCToClientChat ITypedProtobuf<CMsgGCCStrike15_v2_GCToClientChat>.Wrap(nint handle) => new CMsgGCCStrike15_v2_GCToClientChatImpl(handle);


  public uint AccountId { get; set; }


  public string Text { get; set; }

}
