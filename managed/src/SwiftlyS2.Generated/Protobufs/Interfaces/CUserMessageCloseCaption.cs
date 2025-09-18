
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageCloseCaption : ITypedProtobuf<CUserMessageCloseCaption>, INetMessage<CUserMessageCloseCaption>
{
  static int INetMessage<CUserMessageCloseCaption>.MessageId => 102;
  
  static string INetMessage<CUserMessageCloseCaption>.MessageName => "CUserMessageCloseCaption";

  static CUserMessageCloseCaption ITypedProtobuf<CUserMessageCloseCaption>.Wrap(nint handle) => new CUserMessageCloseCaptionImpl(handle);


  public int Hash { get; set; }


  public float Duration { get; set; }


  public bool FromPlayer { get; set; }


  public int EntIndex { get; set; }

}
