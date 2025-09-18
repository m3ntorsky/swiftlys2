
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoCustomDataCallbacks : ITypedProtobuf<CDemoCustomDataCallbacks>
{
  static CDemoCustomDataCallbacks ITypedProtobuf<CDemoCustomDataCallbacks>.Wrap(nint handle) => new CDemoCustomDataCallbacksImpl(handle);


  public IProtobufRepeatedFieldValueType<string> SaveId { get; }

}
