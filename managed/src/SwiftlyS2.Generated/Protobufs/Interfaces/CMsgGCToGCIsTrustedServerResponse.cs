
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCToGCIsTrustedServerResponse : ITypedProtobuf<CMsgGCToGCIsTrustedServerResponse>
{
  static CMsgGCToGCIsTrustedServerResponse ITypedProtobuf<CMsgGCToGCIsTrustedServerResponse>.Wrap(nint handle) => new CMsgGCToGCIsTrustedServerResponseImpl(handle);


  public bool IsTrusted { get; set; }

}
