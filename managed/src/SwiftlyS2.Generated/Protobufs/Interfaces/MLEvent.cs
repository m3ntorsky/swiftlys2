
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface MLEvent : ITypedProtobuf<MLEvent>
{
  static MLEvent ITypedProtobuf<MLEvent>.Wrap(nint handle) => new MLEventImpl(handle);


  public string EventName { get; set; }


  public IProtobufRepeatedFieldSubMessageType<MLDict> Data { get; }

}
