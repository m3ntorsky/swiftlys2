
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CPredictionEvent_StringCommand : ITypedProtobuf<CPredictionEvent_StringCommand>
{
  static CPredictionEvent_StringCommand ITypedProtobuf<CPredictionEvent_StringCommand>.Wrap(nint handle) => new CPredictionEvent_StringCommandImpl(handle);


  public string Command { get; set; }

}
