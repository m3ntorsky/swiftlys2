
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgApplyStickerImpl : TypedProtobuf<CMsgApplySticker>, CMsgApplySticker
{
  public CMsgApplyStickerImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public ulong StickerItemId
  { get => Accessor.GetUInt64("sticker_item_id"); set => Accessor.SetUInt64("sticker_item_id", value); }


  public ulong ItemItemId
  { get => Accessor.GetUInt64("item_item_id"); set => Accessor.SetUInt64("item_item_id", value); }


  public uint StickerSlot
  { get => Accessor.GetUInt32("sticker_slot"); set => Accessor.SetUInt32("sticker_slot", value); }


  public uint BaseitemDefidx
  { get => Accessor.GetUInt32("baseitem_defidx"); set => Accessor.SetUInt32("baseitem_defidx", value); }


  public float StickerWear
  { get => Accessor.GetFloat("sticker_wear"); set => Accessor.SetFloat("sticker_wear", value); }

}
