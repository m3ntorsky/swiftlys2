
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgLeaveParty : ITypedProtobuf<CMsgLeaveParty>
{
  static CMsgLeaveParty ITypedProtobuf<CMsgLeaveParty>.Wrap(nint handle) => new CMsgLeavePartyImpl(handle);


}
