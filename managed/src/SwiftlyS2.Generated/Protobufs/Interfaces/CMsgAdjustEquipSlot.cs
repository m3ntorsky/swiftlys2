
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgAdjustEquipSlot : ITypedProtobuf<CMsgAdjustEquipSlot>
{
  static CMsgAdjustEquipSlot ITypedProtobuf<CMsgAdjustEquipSlot>.Wrap(nint handle) => new CMsgAdjustEquipSlotImpl(handle);


  public uint ClassId { get; set; }


  public uint SlotId { get; set; }


  public ulong ItemId { get; set; }

}
