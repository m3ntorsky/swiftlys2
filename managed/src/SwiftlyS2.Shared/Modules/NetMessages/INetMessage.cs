using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.NetMessages;

public interface INetMessage<T> where T : INetMessage<T>, ITypedProtobuf<T> {

  public static abstract int MessageId { get; }

}