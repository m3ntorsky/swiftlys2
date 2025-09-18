
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgApplySticker : ITypedProtobuf<CMsgApplySticker>
{
  static CMsgApplySticker ITypedProtobuf<CMsgApplySticker>.Wrap(nint handle) => new CMsgApplyStickerImpl(handle);


  public ulong StickerItemId { get; set; }


  public ulong ItemItemId { get; set; }


  public uint StickerSlot { get; set; }


  public uint BaseitemDefidx { get; set; }


  public float StickerWear { get; set; }

}
