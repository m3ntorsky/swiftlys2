
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface ScoreLeaderboardData_AccountEntries : ITypedProtobuf<ScoreLeaderboardData_AccountEntries>
{
  static ScoreLeaderboardData_AccountEntries ITypedProtobuf<ScoreLeaderboardData_AccountEntries>.Wrap(nint handle) => new ScoreLeaderboardData_AccountEntriesImpl(handle);


  public uint Accountid { get; set; }


  public IProtobufRepeatedFieldSubMessageType<ScoreLeaderboardData_Entry> Entries { get; }

}
