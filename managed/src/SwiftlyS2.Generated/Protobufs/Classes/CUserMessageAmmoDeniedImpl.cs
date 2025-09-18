
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CUserMessageAmmoDeniedImpl : NetMessage<CUserMessageAmmoDenied>, CUserMessageAmmoDenied
{
  public CUserMessageAmmoDeniedImpl(nint handle): base(handle)
  {
  }


  public uint AmmoId
  { get => Accessor.GetUInt32("ammo_id"); set => Accessor.SetUInt32("ammo_id", value); }

}
