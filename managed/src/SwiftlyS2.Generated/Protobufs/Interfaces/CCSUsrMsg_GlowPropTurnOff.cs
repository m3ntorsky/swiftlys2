
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_GlowPropTurnOff : ITypedProtobuf<CCSUsrMsg_GlowPropTurnOff>, INetMessage<CCSUsrMsg_GlowPropTurnOff>
{
  static int INetMessage<CCSUsrMsg_GlowPropTurnOff>.MessageId => 360;
  
  static string INetMessage<CCSUsrMsg_GlowPropTurnOff>.MessageName => "CCSUsrMsg_GlowPropTurnOff";

  static CCSUsrMsg_GlowPropTurnOff ITypedProtobuf<CCSUsrMsg_GlowPropTurnOff>.Wrap(nint handle) => new CCSUsrMsg_GlowPropTurnOffImpl(handle);


  public int Entidx { get; set; }

}
