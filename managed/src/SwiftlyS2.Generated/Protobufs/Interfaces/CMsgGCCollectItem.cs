
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCollectItem : ITypedProtobuf<CMsgGCCollectItem>
{
  static CMsgGCCollectItem ITypedProtobuf<CMsgGCCollectItem>.Wrap(nint handle) => new CMsgGCCollectItemImpl(handle);


  public ulong CollectionItemId { get; set; }


  public ulong SubjectItemId { get; set; }

}
