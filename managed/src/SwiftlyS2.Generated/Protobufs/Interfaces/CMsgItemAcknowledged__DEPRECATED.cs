
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgItemAcknowledged__DEPRECATED : ITypedProtobuf<CMsgItemAcknowledged__DEPRECATED>
{
  static CMsgItemAcknowledged__DEPRECATED ITypedProtobuf<CMsgItemAcknowledged__DEPRECATED>.Wrap(nint handle) => new CMsgItemAcknowledged__DEPRECATEDImpl(handle);


  public uint AccountId { get; set; }


  public uint Inventory { get; set; }


  public uint DefIndex { get; set; }


  public uint Quality { get; set; }


  public uint Rarity { get; set; }


  public uint Origin { get; set; }


  public ulong ItemId { get; set; }

}
