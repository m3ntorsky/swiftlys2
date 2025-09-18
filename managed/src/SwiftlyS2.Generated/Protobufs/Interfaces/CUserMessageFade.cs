
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageFade : ITypedProtobuf<CUserMessageFade>, INetMessage<CUserMessageFade>
{
  static int INetMessage<CUserMessageFade>.MessageId => 106;
  
  static string INetMessage<CUserMessageFade>.MessageName => "CUserMessageFade";

  static CUserMessageFade ITypedProtobuf<CUserMessageFade>.Wrap(nint handle) => new CUserMessageFadeImpl(handle);


  public uint Duration { get; set; }


  public uint HoldTime { get; set; }


  public uint Flags { get; set; }


  public int Color { get; set; }

}
