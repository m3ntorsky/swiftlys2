
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_Shake : ITypedProtobuf<CCSUsrMsg_Shake>, INetMessage<CCSUsrMsg_Shake>
{
  static int INetMessage<CCSUsrMsg_Shake>.MessageId => 312;
  
  static string INetMessage<CCSUsrMsg_Shake>.MessageName => "CCSUsrMsg_Shake";

  static CCSUsrMsg_Shake ITypedProtobuf<CCSUsrMsg_Shake>.Wrap(nint handle) => new CCSUsrMsg_ShakeImpl(handle);


  public int Command { get; set; }


  public float LocalAmplitude { get; set; }


  public float Frequency { get; set; }


  public float Duration { get; set; }

}
