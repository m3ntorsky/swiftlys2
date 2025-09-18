using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;


internal class NetMessageService : IDisposable {

  public void Send<T>(Action<T> configureMessage) where T : ITypedProtobuf<T>, INetMessage<T> {
    var handle = NativeNetMessages.AllocateNetMessageByID(T.MessageId);
    var message = T.Wrap(handle);
    configureMessage(message);
    NativeNetMessages.SendMessage(handle, T.MessageId, 0);
    NativeNetMessages.DeallocateNetMessage(handle);
  }
  public void Dispose() {
  }
}