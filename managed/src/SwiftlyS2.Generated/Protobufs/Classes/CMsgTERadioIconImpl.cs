
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgTERadioIconImpl : TypedProtobuf<CMsgTERadioIcon>, CMsgTERadioIcon
{
  public CMsgTERadioIconImpl(nint handle): base(handle)
  {
  }


  public int Player
  { get => Accessor.GetInt32("player"); set => Accessor.SetInt32("player", value); }

}
