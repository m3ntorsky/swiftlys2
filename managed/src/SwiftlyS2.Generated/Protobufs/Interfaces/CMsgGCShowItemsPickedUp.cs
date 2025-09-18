
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCShowItemsPickedUp : ITypedProtobuf<CMsgGCShowItemsPickedUp>
{
  static CMsgGCShowItemsPickedUp ITypedProtobuf<CMsgGCShowItemsPickedUp>.Wrap(nint handle) => new CMsgGCShowItemsPickedUpImpl(handle);


  public ulong PlayerSteamid { get; set; }

}
