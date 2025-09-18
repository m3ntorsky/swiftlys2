
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgSOCacheHaveVersion : ITypedProtobuf<CMsgSOCacheHaveVersion>
{
  static CMsgSOCacheHaveVersion ITypedProtobuf<CMsgSOCacheHaveVersion>.Wrap(nint handle) => new CMsgSOCacheHaveVersionImpl(handle);


  public CMsgSOIDOwner Soid { get; }


  public ulong Version { get; set; }

}
