
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgSOCacheSubscriptionRefresh : ITypedProtobuf<CMsgSOCacheSubscriptionRefresh>
{
  static CMsgSOCacheSubscriptionRefresh ITypedProtobuf<CMsgSOCacheSubscriptionRefresh>.Wrap(nint handle) => new CMsgSOCacheSubscriptionRefreshImpl(handle);


  public CMsgSOIDOwner OwnerSoid { get; }

}
