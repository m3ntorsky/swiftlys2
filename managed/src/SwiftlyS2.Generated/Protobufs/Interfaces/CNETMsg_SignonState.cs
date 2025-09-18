
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CNETMsg_SignonState : ITypedProtobuf<CNETMsg_SignonState>, INetMessage<CNETMsg_SignonState>
{
  static int INetMessage<CNETMsg_SignonState>.MessageId => 7;
  
  static string INetMessage<CNETMsg_SignonState>.MessageName => "CNETMsg_SignonState";

  static CNETMsg_SignonState ITypedProtobuf<CNETMsg_SignonState>.Wrap(nint handle) => new CNETMsg_SignonStateImpl(handle);


  public SignonState_t SignonState { get; set; }


  public uint SpawnCount { get; set; }


  public uint NumServerPlayers { get; set; }


  public IProtobufRepeatedFieldValueType<string> PlayersNetworkids { get; }


  public string MapName { get; set; }


  public string Addons { get; set; }

}
