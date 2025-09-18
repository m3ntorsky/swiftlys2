using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

internal class TestNetMessageImpl : NetMessage<TestNetMessage>, TestNetMessage
{

  public ProtobufRepeatedFieldValueType<int> Test
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "test"); }
}

public interface TestNetMessage : ITypedProtobuf<TestNetMessage>, INetMessage<TestNetMessage> {

  static int INetMessage<TestNetMessage>.MessageId => 1;

  static TestNetMessage ITypedProtobuf<TestNetMessage>.Create() {
    return new TestNetMessageImpl();
  }

  ProtobufRepeatedFieldValueType<int> Test { get; }
}

internal class Test2NetMessageImpl : TypedProtobuf<Test2NetMessage>, Test2NetMessage
{

  public ProtobufRepeatedFieldValueType<int> Test
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "test"); }
}

public interface Test2NetMessage : ITypedProtobuf<Test2NetMessage>
{


  static Test2NetMessage ITypedProtobuf<Test2NetMessage>.Create()
  {
    return new Test2NetMessageImpl();
  }

  ProtobufRepeatedFieldValueType<int> Test { get; }
}