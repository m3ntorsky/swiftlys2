using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

internal class NetMessage<T> : TypedProtobuf<T>, INativeHandle where T : ITypedProtobuf<T>, INetMessage<T> {

  private NetMessageAllocableNativeHandle? _allocatedHandle;

  /*

  Evil hack to convert a CNetMessagePB<>* to google::protobuf::Message*

  CNetMessage memory layout:
  vtable -> 8 bytes
  members -> 40 bytes

  and CNetMessagePB inheritance: public CNetMessage, public PROTO_TYPE
  so we can cast to PROTO_TYPE* by adding 48 bytes to the handle

  */
  public NetMessage(nint handle) : base(handle + 48) {
    _allocatedHandle = new(handle);
  }

}