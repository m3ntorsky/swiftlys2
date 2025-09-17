using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.NetMessages;

public interface ITypedProtobuf<T> : INativeHandle where T : ITypedProtobuf<T> {

  public IProtobuf Accessor { get; }

  internal abstract static T Wrap(nint handle);

}


