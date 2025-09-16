using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "smoke_beacon_paradrop"
/// </summary>
internal class EventSmokeBeaconParadropImpl : GameEvent<EventSmokeBeaconParadrop>, EventSmokeBeaconParadrop
{

  public EventSmokeBeaconParadropImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short ParaDrop
  { get => (short)GetInt("paradrop"); set => SetInt("paradrop", value); }
}
