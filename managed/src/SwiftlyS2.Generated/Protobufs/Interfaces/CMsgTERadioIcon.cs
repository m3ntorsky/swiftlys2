
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgTERadioIcon : ITypedProtobuf<CMsgTERadioIcon>
{
  static CMsgTERadioIcon ITypedProtobuf<CMsgTERadioIcon>.Wrap(nint handle) => new CMsgTERadioIconImpl(handle);


  public int Player { get; set; }

}
