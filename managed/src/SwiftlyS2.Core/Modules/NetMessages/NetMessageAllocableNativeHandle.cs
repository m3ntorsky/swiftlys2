using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Core.NetMessages;

internal class NetMessageAllocableNativeHandle : AllocableNativeHandle {

  public NetMessageAllocableNativeHandle(nint handle) : base(handle, true) {
  }

  protected override bool Free() {
    NativeNetMessages.DeallocateNetMessage(GetHandle());
    return true;
  }

}