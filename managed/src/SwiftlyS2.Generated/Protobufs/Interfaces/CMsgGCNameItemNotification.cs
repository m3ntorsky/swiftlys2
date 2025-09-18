
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCNameItemNotification : ITypedProtobuf<CMsgGCNameItemNotification>
{
  static CMsgGCNameItemNotification ITypedProtobuf<CMsgGCNameItemNotification>.Wrap(nint handle) => new CMsgGCNameItemNotificationImpl(handle);


  public ulong PlayerSteamid { get; set; }


  public uint ItemDefIndex { get; set; }


  public string ItemNameCustom { get; set; }

}
