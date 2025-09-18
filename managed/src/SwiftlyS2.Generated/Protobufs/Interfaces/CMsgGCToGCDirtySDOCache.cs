
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCToGCDirtySDOCache : ITypedProtobuf<CMsgGCToGCDirtySDOCache>
{
  static CMsgGCToGCDirtySDOCache ITypedProtobuf<CMsgGCToGCDirtySDOCache>.Wrap(nint handle) => new CMsgGCToGCDirtySDOCacheImpl(handle);


  public uint SdoType { get; set; }


  public ulong KeyUint64 { get; set; }

}
