
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CWorkshop_PopulateItemDescriptions_Request_SingleItemDescription : ITypedProtobuf<CWorkshop_PopulateItemDescriptions_Request_SingleItemDescription>
{
  static CWorkshop_PopulateItemDescriptions_Request_SingleItemDescription ITypedProtobuf<CWorkshop_PopulateItemDescriptions_Request_SingleItemDescription>.Wrap(nint handle) => new CWorkshop_PopulateItemDescriptions_Request_SingleItemDescriptionImpl(handle);


  public uint Gameitemid { get; set; }


  public string ItemDescription { get; set; }


  public bool OnePerAccount { get; set; }

}
