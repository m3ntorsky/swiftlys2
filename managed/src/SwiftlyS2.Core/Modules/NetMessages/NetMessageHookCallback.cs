using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

internal delegate bool NetMessageClientHookCallbackDelegate(int playerId, int msgId, nint pMessage);
internal delegate bool NetMessageServerHookCallbackDelegate(nint pPlayerMask, int msgId, nint pMessage);

internal class NetMessageClientHookCallback {

}

internal class NetMessageClientHookCallback<T> : NetMessageClientHookCallback where T : ITypedProtobuf<T>, INetMessage<T> {

  public NetMessageClientHookCallback(NetMessageClientHookCallbackDelegate callback) {
    NativeNetMessages.AddNetMessageClientHook(T.MessageId, callback);
  }

  public void Dispose() {
    NativeNetMessages.RemoveNetMessageClientHook(T.MessageId);
  }

}
