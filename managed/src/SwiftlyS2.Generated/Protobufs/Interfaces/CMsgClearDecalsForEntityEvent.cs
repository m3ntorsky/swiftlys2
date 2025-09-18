
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgClearDecalsForEntityEvent : ITypedProtobuf<CMsgClearDecalsForEntityEvent>, INetMessage<CMsgClearDecalsForEntityEvent>
{
  static int INetMessage<CMsgClearDecalsForEntityEvent>.MessageId => 204;
  
  static string INetMessage<CMsgClearDecalsForEntityEvent>.MessageName => "CMsgClearDecalsForEntityEvent";

  static CMsgClearDecalsForEntityEvent ITypedProtobuf<CMsgClearDecalsForEntityEvent>.Wrap(nint handle) => new CMsgClearDecalsForEntityEventImpl(handle);


  public uint Flagstoclear { get; set; }


  public uint Entityhandle { get; set; }

}
