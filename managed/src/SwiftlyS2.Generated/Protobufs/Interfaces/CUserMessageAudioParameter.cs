
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageAudioParameter : ITypedProtobuf<CUserMessageAudioParameter>, INetMessage<CUserMessageAudioParameter>
{
  static int INetMessage<CUserMessageAudioParameter>.MessageId => 144;
  
  static string INetMessage<CUserMessageAudioParameter>.MessageName => "CUserMessageAudioParameter";

  static CUserMessageAudioParameter ITypedProtobuf<CUserMessageAudioParameter>.Wrap(nint handle) => new CUserMessageAudioParameterImpl(handle);


  public uint ParameterType { get; set; }


  public uint NameHashCode { get; set; }


  public float Value { get; set; }


  public uint IntValue { get; set; }

}
