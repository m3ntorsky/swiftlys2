
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageAmmoDenied : ITypedProtobuf<CUserMessageAmmoDenied>, INetMessage<CUserMessageAmmoDenied>
{
  static int INetMessage<CUserMessageAmmoDenied>.MessageId => 132;
  
  static string INetMessage<CUserMessageAmmoDenied>.MessageName => "CUserMessageAmmoDenied";

  static CUserMessageAmmoDenied ITypedProtobuf<CUserMessageAmmoDenied>.Wrap(nint handle) => new CUserMessageAmmoDeniedImpl(handle);


  public uint AmmoId { get; set; }

}
