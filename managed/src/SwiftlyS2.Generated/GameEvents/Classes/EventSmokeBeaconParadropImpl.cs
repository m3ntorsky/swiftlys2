using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "smoke_beacon_paradrop"
/// </summary>
internal class EventSmokeBeaconParadropImpl : TypedGameEvent<EventSmokeBeaconParadrop>, EventSmokeBeaconParadrop
{

  public EventSmokeBeaconParadropImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short ParaDrop
  { get => (short)Accessor.GetInt32("paradrop"); set => Accessor.SetInt32("paradrop", value); }
}
