
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_SSUI : ITypedProtobuf<CCSUsrMsg_SSUI>, INetMessage<CCSUsrMsg_SSUI>
{
  static int INetMessage<CCSUsrMsg_SSUI>.MessageId => 372;
  
  static string INetMessage<CCSUsrMsg_SSUI>.MessageName => "CCSUsrMsg_SSUI";

  static CCSUsrMsg_SSUI ITypedProtobuf<CCSUsrMsg_SSUI>.Wrap(nint handle) => new CCSUsrMsg_SSUIImpl(handle);


  public bool Show { get; set; }


  public float StartTime { get; set; }


  public float EndTime { get; set; }

}
