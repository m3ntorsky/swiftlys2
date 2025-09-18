
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCDev_SchemaReservationRequest : ITypedProtobuf<CMsgGCDev_SchemaReservationRequest>
{
  static CMsgGCDev_SchemaReservationRequest ITypedProtobuf<CMsgGCDev_SchemaReservationRequest>.Wrap(nint handle) => new CMsgGCDev_SchemaReservationRequestImpl(handle);


  public string SchemaTypename { get; set; }


  public string InstanceName { get; set; }


  public ulong Context { get; set; }


  public ulong Id { get; set; }

}
