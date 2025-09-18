
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgSerializedSOCache_Cache : ITypedProtobuf<CMsgSerializedSOCache_Cache>
{
  static CMsgSerializedSOCache_Cache ITypedProtobuf<CMsgSerializedSOCache_Cache>.Wrap(nint handle) => new CMsgSerializedSOCache_CacheImpl(handle);


  public uint Type { get; set; }


  public ulong Id { get; set; }


  public IProtobufRepeatedFieldSubMessageType<CMsgSerializedSOCache_Cache_Version> Versions { get; }


  public IProtobufRepeatedFieldSubMessageType<CMsgSerializedSOCache_TypeCache> TypeCaches { get; }

}
