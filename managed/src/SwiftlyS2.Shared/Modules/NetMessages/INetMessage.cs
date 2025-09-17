using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.NetMessages;

public interface INetMessage<T> : IAllocableNativeHandle where T : INetMessage<T>, ITypedProtobuf<T> {

  internal static abstract T Wrap(nint handle);

  public static abstract int MessageId { get; }

  // TODO: revisit this later, to properly handle player mask
  public void SendMessage();


}