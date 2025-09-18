
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgApplyStatTrakSwap : ITypedProtobuf<CMsgApplyStatTrakSwap>
{
  static CMsgApplyStatTrakSwap ITypedProtobuf<CMsgApplyStatTrakSwap>.Wrap(nint handle) => new CMsgApplyStatTrakSwapImpl(handle);


  public ulong ToolItemId { get; set; }


  public ulong Item1ItemId { get; set; }


  public ulong Item2ItemId { get; set; }

}
