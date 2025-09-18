
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageItemPickup : ITypedProtobuf<CUserMessageItemPickup>, INetMessage<CUserMessageItemPickup>
{
  static int INetMessage<CUserMessageItemPickup>.MessageId => 131;
  
  static string INetMessage<CUserMessageItemPickup>.MessageName => "CUserMessageItemPickup";

  static CUserMessageItemPickup ITypedProtobuf<CUserMessageItemPickup>.Wrap(nint handle) => new CUserMessageItemPickupImpl(handle);


  public string Itemname { get; set; }

}
