
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgClearEntityDecalsEvent : ITypedProtobuf<CMsgClearEntityDecalsEvent>, INetMessage<CMsgClearEntityDecalsEvent>
{
  static int INetMessage<CMsgClearEntityDecalsEvent>.MessageId => 203;
  
  static string INetMessage<CMsgClearEntityDecalsEvent>.MessageName => "CMsgClearEntityDecalsEvent";

  static CMsgClearEntityDecalsEvent ITypedProtobuf<CMsgClearEntityDecalsEvent>.Wrap(nint handle) => new CMsgClearEntityDecalsEventImpl(handle);


  public uint Flagstoclear { get; set; }

}
