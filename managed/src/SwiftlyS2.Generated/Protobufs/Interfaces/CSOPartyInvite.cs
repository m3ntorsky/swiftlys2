
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSOPartyInvite : ITypedProtobuf<CSOPartyInvite>
{
  static CSOPartyInvite ITypedProtobuf<CSOPartyInvite>.Wrap(nint handle) => new CSOPartyInviteImpl(handle);


  public ulong GroupId { get; set; }


  public ulong SenderId { get; set; }


  public string SenderName { get; set; }

}
