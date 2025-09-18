
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCUserTrackTimePlayedConsecutively : ITypedProtobuf<CMsgGCUserTrackTimePlayedConsecutively>
{
  static CMsgGCUserTrackTimePlayedConsecutively ITypedProtobuf<CMsgGCUserTrackTimePlayedConsecutively>.Wrap(nint handle) => new CMsgGCUserTrackTimePlayedConsecutivelyImpl(handle);


  public uint State { get; set; }

}
