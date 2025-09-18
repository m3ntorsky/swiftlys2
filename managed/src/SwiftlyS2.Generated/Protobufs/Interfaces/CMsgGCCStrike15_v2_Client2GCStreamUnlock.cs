
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_Client2GCStreamUnlock : ITypedProtobuf<CMsgGCCStrike15_v2_Client2GCStreamUnlock>
{
  static CMsgGCCStrike15_v2_Client2GCStreamUnlock ITypedProtobuf<CMsgGCCStrike15_v2_Client2GCStreamUnlock>.Wrap(nint handle) => new CMsgGCCStrike15_v2_Client2GCStreamUnlockImpl(handle);


  public ulong Ticket { get; set; }


  public int Os { get; set; }

}
