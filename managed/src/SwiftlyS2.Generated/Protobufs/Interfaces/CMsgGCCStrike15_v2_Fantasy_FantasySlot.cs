
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_Fantasy_FantasySlot : ITypedProtobuf<CMsgGCCStrike15_v2_Fantasy_FantasySlot>
{
  static CMsgGCCStrike15_v2_Fantasy_FantasySlot ITypedProtobuf<CMsgGCCStrike15_v2_Fantasy_FantasySlot>.Wrap(nint handle) => new CMsgGCCStrike15_v2_Fantasy_FantasySlotImpl(handle);


  public int Type { get; set; }


  public int Pick { get; set; }


  public ulong Itemid { get; set; }

}
