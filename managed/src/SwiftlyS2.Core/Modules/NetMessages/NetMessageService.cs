using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;


internal class NetMessageService : IDisposable {


  public NetMessageService() {
  }

  private nint AllocateNetMessage(int msgId) {
    var handle = NativeNetMessages.AllocateNetMessageByID(msgId);
    if (handle == 0) throw new InvalidOperationException("Failed to allocate net message. This is possibly caused by the message ID is already deprecated not supported in game.");
    return handle;
  }

  public T Create<T>() where T : ITypedProtobuf<T>, INetMessage<T> {
    var handle = AllocateNetMessage(T.MessageId);
    var message = T.Wrap(handle);
    return message;
  }

  public void Send<T>(Action<T> configureMessage) where T : ITypedProtobuf<T>, INetMessage<T> {
    var handle = AllocateNetMessage(T.MessageId);
    var message = T.Wrap(handle);
    configureMessage(message);
    NativeNetMessages.SendMessage(handle, T.MessageId, 0);
  }
}