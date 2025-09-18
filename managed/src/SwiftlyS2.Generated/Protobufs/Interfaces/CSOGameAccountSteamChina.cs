
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSOGameAccountSteamChina : ITypedProtobuf<CSOGameAccountSteamChina>
{
  static CSOGameAccountSteamChina ITypedProtobuf<CSOGameAccountSteamChina>.Wrap(nint handle) => new CSOGameAccountSteamChinaImpl(handle);


  public uint TimeLastUpdate { get; set; }


  public uint TimeCommsBan { get; set; }


  public uint TimePlayBan { get; set; }

}
