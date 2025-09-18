
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCRequestAnnouncementsResponse : ITypedProtobuf<CMsgGCRequestAnnouncementsResponse>
{
  static CMsgGCRequestAnnouncementsResponse ITypedProtobuf<CMsgGCRequestAnnouncementsResponse>.Wrap(nint handle) => new CMsgGCRequestAnnouncementsResponseImpl(handle);


  public string AnnouncementTitle { get; set; }


  public string Announcement { get; set; }


  public string NextmatchTitle { get; set; }


  public string Nextmatch { get; set; }

}
