
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCError : ITypedProtobuf<CMsgGCError>
{
  static CMsgGCError ITypedProtobuf<CMsgGCError>.Wrap(nint handle) => new CMsgGCErrorImpl(handle);


  public string ErrorText { get; set; }

}
