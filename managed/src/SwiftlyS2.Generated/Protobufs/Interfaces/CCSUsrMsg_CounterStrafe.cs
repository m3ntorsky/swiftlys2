
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_CounterStrafe : ITypedProtobuf<CCSUsrMsg_CounterStrafe>, INetMessage<CCSUsrMsg_CounterStrafe>
{
  static int INetMessage<CCSUsrMsg_CounterStrafe>.MessageId => 385;
  
  static string INetMessage<CCSUsrMsg_CounterStrafe>.MessageName => "CCSUsrMsg_CounterStrafe";

  static CCSUsrMsg_CounterStrafe ITypedProtobuf<CCSUsrMsg_CounterStrafe>.Wrap(nint handle) => new CCSUsrMsg_CounterStrafeImpl(handle);


  public int PressToReleaseNs { get; set; }


  public int TotalKeysDown { get; set; }

}
