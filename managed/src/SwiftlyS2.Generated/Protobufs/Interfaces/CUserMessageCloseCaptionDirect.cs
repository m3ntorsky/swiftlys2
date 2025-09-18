
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageCloseCaptionDirect : ITypedProtobuf<CUserMessageCloseCaptionDirect>, INetMessage<CUserMessageCloseCaptionDirect>
{
  static int INetMessage<CUserMessageCloseCaptionDirect>.MessageId => 103;
  
  static string INetMessage<CUserMessageCloseCaptionDirect>.MessageName => "CUserMessageCloseCaptionDirect";

  static CUserMessageCloseCaptionDirect ITypedProtobuf<CUserMessageCloseCaptionDirect>.Wrap(nint handle) => new CUserMessageCloseCaptionDirectImpl(handle);


  public int Hash { get; set; }


  public float Duration { get; set; }


  public bool FromPlayer { get; set; }


  public int EntIndex { get; set; }

}
