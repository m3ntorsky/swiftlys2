using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

internal class NetMessage<T> : AllocableNativeHandle {

  public Protobuf Accessor { get; set; }

  public NetMessage(nint handle) : base(handle, true) {
    Handle = handle;
    Accessor = new Protobuf(this);
  }
  public nint Handle { get; private set; }
    protected override bool Free() {
    Accessor.MarkAsInvalid();
    return true;
  }

  public void SendMessage()
  {
      throw new NotImplementedException();
  }
}