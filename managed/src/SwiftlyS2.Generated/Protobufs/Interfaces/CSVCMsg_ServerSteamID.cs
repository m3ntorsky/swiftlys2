
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CSVCMsg_ServerSteamID : ITypedProtobuf<CSVCMsg_ServerSteamID>, INetMessage<CSVCMsg_ServerSteamID>
{
  static int INetMessage<CSVCMsg_ServerSteamID>.MessageId => 63;
  
  static string INetMessage<CSVCMsg_ServerSteamID>.MessageName => "CSVCMsg_ServerSteamID";

  static CSVCMsg_ServerSteamID ITypedProtobuf<CSVCMsg_ServerSteamID>.Wrap(nint handle) => new CSVCMsg_ServerSteamIDImpl(handle);


  public ulong SteamId { get; set; }

}
