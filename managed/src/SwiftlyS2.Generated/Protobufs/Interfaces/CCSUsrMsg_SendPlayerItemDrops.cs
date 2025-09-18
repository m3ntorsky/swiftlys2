
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_SendPlayerItemDrops : ITypedProtobuf<CCSUsrMsg_SendPlayerItemDrops>, INetMessage<CCSUsrMsg_SendPlayerItemDrops>
{
  static int INetMessage<CCSUsrMsg_SendPlayerItemDrops>.MessageId => 361;
  
  static string INetMessage<CCSUsrMsg_SendPlayerItemDrops>.MessageName => "CCSUsrMsg_SendPlayerItemDrops";

  static CCSUsrMsg_SendPlayerItemDrops ITypedProtobuf<CCSUsrMsg_SendPlayerItemDrops>.Wrap(nint handle) => new CCSUsrMsg_SendPlayerItemDropsImpl(handle);


  public IProtobufRepeatedFieldSubMessageType<CEconItemPreviewDataBlock> EntityUpdates { get; }

}
