
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CGameInfo_CDotaGameInfo_CHeroSelectEvent : ITypedProtobuf<CGameInfo_CDotaGameInfo_CHeroSelectEvent>
{
  static CGameInfo_CDotaGameInfo_CHeroSelectEvent ITypedProtobuf<CGameInfo_CDotaGameInfo_CHeroSelectEvent>.Wrap(nint handle) => new CGameInfo_CDotaGameInfo_CHeroSelectEventImpl(handle);


  public bool IsPick { get; set; }


  public uint Team { get; set; }


  public int HeroId { get; set; }

}
