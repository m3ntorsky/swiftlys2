
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCReportAbuse : ITypedProtobuf<CMsgGCReportAbuse>
{
  static CMsgGCReportAbuse ITypedProtobuf<CMsgGCReportAbuse>.Wrap(nint handle) => new CMsgGCReportAbuseImpl(handle);


  public ulong TargetSteamId { get; set; }


  public string Description { get; set; }


  public ulong Gid { get; set; }


  public uint AbuseType { get; set; }


  public uint ContentType { get; set; }


  public int TargetGameServerIp { get; set; }


  public uint TargetGameServerPort { get; set; }

}
