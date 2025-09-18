
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoPacket : ITypedProtobuf<CDemoPacket>
{
  static CDemoPacket ITypedProtobuf<CDemoPacket>.Wrap(nint handle) => new CDemoPacketImpl(handle);


  public byte[] Data { get; set; }

}
