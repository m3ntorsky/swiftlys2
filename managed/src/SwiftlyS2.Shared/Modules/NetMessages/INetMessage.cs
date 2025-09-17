namespace SwiftlyS2.Shared.NetMessages;

public interface INetMessage : IProtobuf {

}

public interface INetMessage<T> : INetMessage where T : INetMessage<T> {

  internal abstract static T From(nint handle);

}