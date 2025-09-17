using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.NetMessages;

public interface IProtobuf : INativeHandle {
}

public interface IProtobuf<T> : IProtobuf where T : IProtobuf<T> {

  internal abstract static T From(nint handle);

}