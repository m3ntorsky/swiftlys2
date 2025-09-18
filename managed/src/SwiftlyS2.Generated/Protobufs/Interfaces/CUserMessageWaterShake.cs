
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageWaterShake : ITypedProtobuf<CUserMessageWaterShake>, INetMessage<CUserMessageWaterShake>
{
  static int INetMessage<CUserMessageWaterShake>.MessageId => 122;
  
  static string INetMessage<CUserMessageWaterShake>.MessageName => "CUserMessageWaterShake";

  static CUserMessageWaterShake ITypedProtobuf<CUserMessageWaterShake>.Wrap(nint handle) => new CUserMessageWaterShakeImpl(handle);


  public uint Command { get; set; }


  public float Amplitude { get; set; }


  public float Frequency { get; set; }


  public float Duration { get; set; }

}
