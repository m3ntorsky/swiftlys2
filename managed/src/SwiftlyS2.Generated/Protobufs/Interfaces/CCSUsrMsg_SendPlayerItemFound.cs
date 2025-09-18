
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_SendPlayerItemFound : ITypedProtobuf<CCSUsrMsg_SendPlayerItemFound>, INetMessage<CCSUsrMsg_SendPlayerItemFound>
{
  static int INetMessage<CCSUsrMsg_SendPlayerItemFound>.MessageId => 363;
  
  static string INetMessage<CCSUsrMsg_SendPlayerItemFound>.MessageName => "CCSUsrMsg_SendPlayerItemFound";

  static CCSUsrMsg_SendPlayerItemFound ITypedProtobuf<CCSUsrMsg_SendPlayerItemFound>.Wrap(nint handle) => new CCSUsrMsg_SendPlayerItemFoundImpl(handle);


  public CEconItemPreviewDataBlock Iteminfo { get; }


  public int Playerslot { get; set; }

}
