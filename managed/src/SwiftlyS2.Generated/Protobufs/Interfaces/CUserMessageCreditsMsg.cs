
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageCreditsMsg : ITypedProtobuf<CUserMessageCreditsMsg>, INetMessage<CUserMessageCreditsMsg>
{
  static int INetMessage<CUserMessageCreditsMsg>.MessageId => 135;
  
  static string INetMessage<CUserMessageCreditsMsg>.MessageName => "CUserMessageCreditsMsg";

  static CUserMessageCreditsMsg ITypedProtobuf<CUserMessageCreditsMsg>.Wrap(nint handle) => new CUserMessageCreditsMsgImpl(handle);


  public eRollType Rolltype { get; set; }


  public float LogoLength { get; set; }

}
