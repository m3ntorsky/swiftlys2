
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgItemAcknowledged : ITypedProtobuf<CMsgItemAcknowledged>
{
  static CMsgItemAcknowledged ITypedProtobuf<CMsgItemAcknowledged>.Wrap(nint handle) => new CMsgItemAcknowledgedImpl(handle);


  public CEconItemPreviewDataBlock Iteminfo { get; }

}
