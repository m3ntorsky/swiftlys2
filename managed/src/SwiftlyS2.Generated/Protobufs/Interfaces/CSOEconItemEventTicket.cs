
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSOEconItemEventTicket : ITypedProtobuf<CSOEconItemEventTicket>
{
  static CSOEconItemEventTicket ITypedProtobuf<CSOEconItemEventTicket>.Wrap(nint handle) => new CSOEconItemEventTicketImpl(handle);


  public uint AccountId { get; set; }


  public uint EventId { get; set; }


  public ulong ItemId { get; set; }

}
