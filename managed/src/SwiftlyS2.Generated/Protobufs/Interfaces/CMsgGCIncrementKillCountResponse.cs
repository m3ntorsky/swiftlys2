
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCIncrementKillCountResponse : ITypedProtobuf<CMsgGCIncrementKillCountResponse>
{
  static CMsgGCIncrementKillCountResponse ITypedProtobuf<CMsgGCIncrementKillCountResponse>.Wrap(nint handle) => new CMsgGCIncrementKillCountResponseImpl(handle);


  public uint KillerAccountId { get; set; }


  public uint NumKills { get; set; }


  public uint ItemDef { get; set; }


  public uint LevelType { get; set; }

}
