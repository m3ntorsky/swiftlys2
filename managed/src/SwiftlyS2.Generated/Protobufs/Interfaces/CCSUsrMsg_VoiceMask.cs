
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_VoiceMask : ITypedProtobuf<CCSUsrMsg_VoiceMask>, INetMessage<CCSUsrMsg_VoiceMask>
{
  static int INetMessage<CCSUsrMsg_VoiceMask>.MessageId => 319;
  
  static string INetMessage<CCSUsrMsg_VoiceMask>.MessageName => "CCSUsrMsg_VoiceMask";

  static CCSUsrMsg_VoiceMask ITypedProtobuf<CCSUsrMsg_VoiceMask>.Wrap(nint handle) => new CCSUsrMsg_VoiceMaskImpl(handle);


  public IProtobufRepeatedFieldSubMessageType<CCSUsrMsg_VoiceMask_PlayerMask> PlayerMasks { get; }


  public bool PlayerModEnable { get; set; }

}
