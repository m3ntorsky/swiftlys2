
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgAdjustEquipSlots : ITypedProtobuf<CMsgAdjustEquipSlots>
{
  static CMsgAdjustEquipSlots ITypedProtobuf<CMsgAdjustEquipSlots>.Wrap(nint handle) => new CMsgAdjustEquipSlotsImpl(handle);


  public IProtobufRepeatedFieldSubMessageType<CMsgAdjustEquipSlot> Slots { get; }

}
