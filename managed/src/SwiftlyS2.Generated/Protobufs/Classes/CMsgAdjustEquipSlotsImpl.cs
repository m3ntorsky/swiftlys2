
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgAdjustEquipSlotsImpl : TypedProtobuf<CMsgAdjustEquipSlots>, CMsgAdjustEquipSlots
{
  public CMsgAdjustEquipSlotsImpl(nint handle): base(handle)
  {
  }


  public IProtobufRepeatedFieldSubMessageType<CMsgAdjustEquipSlot> Slots
  { get => new ProtobufRepeatedFieldSubMessageType<CMsgAdjustEquipSlot>(Accessor, "slots"); }

}
