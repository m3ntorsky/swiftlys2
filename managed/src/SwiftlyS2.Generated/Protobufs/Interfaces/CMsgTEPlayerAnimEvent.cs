
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEPlayerAnimEvent : ITypedProtobuf<CMsgTEPlayerAnimEvent>, INetMessage<CMsgTEPlayerAnimEvent>
{
  static int INetMessage<CMsgTEPlayerAnimEvent>.MessageId => 450;
  
  static string INetMessage<CMsgTEPlayerAnimEvent>.MessageName => "CMsgTEPlayerAnimEvent";

  static CMsgTEPlayerAnimEvent ITypedProtobuf<CMsgTEPlayerAnimEvent>.Wrap(nint handle) => new CMsgTEPlayerAnimEventImpl(handle);


  public int Player { get; set; }


  public uint Event { get; set; }


  public int Data { get; set; }

}
