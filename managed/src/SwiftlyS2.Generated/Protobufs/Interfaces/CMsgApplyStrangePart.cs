
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgApplyStrangePart : ITypedProtobuf<CMsgApplyStrangePart>
{
  static CMsgApplyStrangePart ITypedProtobuf<CMsgApplyStrangePart>.Wrap(nint handle) => new CMsgApplyStrangePartImpl(handle);


  public ulong StrangePartItemId { get; set; }


  public ulong ItemItemId { get; set; }

}
