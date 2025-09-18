
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface NetMessagePacketEnd : ITypedProtobuf<NetMessagePacketEnd>
{
  static NetMessagePacketEnd ITypedProtobuf<NetMessagePacketEnd>.Wrap(nint handle) => new NetMessagePacketEndImpl(handle);


}
