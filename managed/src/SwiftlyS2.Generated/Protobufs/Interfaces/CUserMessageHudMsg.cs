
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageHudMsg : ITypedProtobuf<CUserMessageHudMsg>, INetMessage<CUserMessageHudMsg>
{
  static int INetMessage<CUserMessageHudMsg>.MessageId => 110;
  
  static string INetMessage<CUserMessageHudMsg>.MessageName => "CUserMessageHudMsg";

  static CUserMessageHudMsg ITypedProtobuf<CUserMessageHudMsg>.Wrap(nint handle) => new CUserMessageHudMsgImpl(handle);


  public uint Channel { get; set; }


  public float X { get; set; }


  public float Y { get; set; }


  public int Color1 { get; set; }


  public int Color2 { get; set; }


  public uint Effect { get; set; }


  public string Message { get; set; }

}
