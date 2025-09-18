
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface TournamentPlayer : ITypedProtobuf<TournamentPlayer>
{
  static TournamentPlayer ITypedProtobuf<TournamentPlayer>.Wrap(nint handle) => new TournamentPlayerImpl(handle);


  public uint AccountId { get; set; }


  public string PlayerNick { get; set; }


  public string PlayerName { get; set; }


  public uint PlayerDob { get; set; }


  public string PlayerFlag { get; set; }


  public string PlayerLocation { get; set; }


  public string PlayerDesc { get; set; }

}
