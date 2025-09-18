
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CSOPersonaDataPublicImpl : TypedProtobuf<CSOPersonaDataPublic>, CSOPersonaDataPublic
{
  public CSOPersonaDataPublicImpl(nint handle): base(handle)
  {
  }


  public int PlayerLevel
  { get => Accessor.GetInt32("player_level"); set => Accessor.SetInt32("player_level", value); }


  public PlayerCommendationInfo Commendation
  { get => new PlayerCommendationInfoImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "commendation")); }


  public bool ElevatedState
  { get => Accessor.GetBool("elevated_state"); set => Accessor.SetBool("elevated_state", value); }


  public uint XpTrailTimestampRefresh
  { get => Accessor.GetUInt32("xp_trail_timestamp_refresh"); set => Accessor.SetUInt32("xp_trail_timestamp_refresh", value); }


  public uint XpTrailLevel
  { get => Accessor.GetUInt32("xp_trail_level"); set => Accessor.SetUInt32("xp_trail_level", value); }

}
