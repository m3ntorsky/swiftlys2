
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgLANServerAvailable : ITypedProtobuf<CMsgLANServerAvailable>
{
  static CMsgLANServerAvailable ITypedProtobuf<CMsgLANServerAvailable>.Wrap(nint handle) => new CMsgLANServerAvailableImpl(handle);


  public ulong LobbyId { get; set; }

}
