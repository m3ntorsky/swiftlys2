
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgSOCacheVersion : ITypedProtobuf<CMsgSOCacheVersion>
{
  static CMsgSOCacheVersion ITypedProtobuf<CMsgSOCacheVersion>.Wrap(nint handle) => new CMsgSOCacheVersionImpl(handle);


  public ulong Version { get; set; }

}
