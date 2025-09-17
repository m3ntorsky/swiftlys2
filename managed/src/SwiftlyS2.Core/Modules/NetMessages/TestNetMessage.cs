using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

internal class TestNetMessageImpl : NetMessage<TestNetMessageImpl>, TestNetMessage
{
  IProtobuf ITypedProtobuf<TestNetMessage>.Accessor { get; }

  public TestNetMessageImpl(nint handle) : base(handle) {
    Accessor = new Protobuf(new NativeHandle(handle));
  }
}

public interface TestNetMessage : ITypedProtobuf<TestNetMessage>, INetMessage<TestNetMessage> {

  static int INetMessage<TestNetMessage>.MessageId => 1;

  static TestNetMessage INetMessage<TestNetMessage>.Wrap(nint handle) {
    return new TestNetMessageImpl(handle);
  }
  static TestNetMessage ITypedProtobuf<TestNetMessage>.Wrap(nint handle)
  {
    return new TestNetMessageImpl(handle);
  }
}