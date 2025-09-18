
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_DisconnectToLobby : ITypedProtobuf<CCSUsrMsg_DisconnectToLobby>, INetMessage<CCSUsrMsg_DisconnectToLobby>
{
  static int INetMessage<CCSUsrMsg_DisconnectToLobby>.MessageId => 335;
  
  static string INetMessage<CCSUsrMsg_DisconnectToLobby>.MessageName => "CCSUsrMsg_DisconnectToLobby";

  static CCSUsrMsg_DisconnectToLobby ITypedProtobuf<CCSUsrMsg_DisconnectToLobby>.Wrap(nint handle) => new CCSUsrMsg_DisconnectToLobbyImpl(handle);


  public int Dummy { get; set; }

}
