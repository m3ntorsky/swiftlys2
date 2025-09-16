using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hostage_killed"
/// </summary>
internal class EventHostageKilledImpl : GameEvent<EventHostageKilled>, EventHostageKilled
{

  public EventHostageKilledImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who killed the hostage
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // hostage entity index
  public short Hostage
  { get => (short)GetInt("hostage"); set => SetInt("hostage", value); }
}
