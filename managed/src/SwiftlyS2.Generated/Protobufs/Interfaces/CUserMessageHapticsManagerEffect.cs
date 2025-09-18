
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageHapticsManagerEffect : ITypedProtobuf<CUserMessageHapticsManagerEffect>, INetMessage<CUserMessageHapticsManagerEffect>
{
  static int INetMessage<CUserMessageHapticsManagerEffect>.MessageId => 151;
  
  static string INetMessage<CUserMessageHapticsManagerEffect>.MessageName => "CUserMessageHapticsManagerEffect";

  static CUserMessageHapticsManagerEffect ITypedProtobuf<CUserMessageHapticsManagerEffect>.Wrap(nint handle) => new CUserMessageHapticsManagerEffectImpl(handle);


  public int HandId { get; set; }


  public uint EffectNameHashCode { get; set; }


  public float EffectScale { get; set; }

}
