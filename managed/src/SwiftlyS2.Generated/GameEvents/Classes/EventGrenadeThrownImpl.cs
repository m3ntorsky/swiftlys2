using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "grenade_thrown"
/// </summary>
internal class EventGrenadeThrownImpl : GameEvent<EventGrenadeThrown>, EventGrenadeThrown
{

  public EventGrenadeThrownImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // weapon name used
  public string Weapon
  { get => GetString("weapon"); set => SetString("weapon", value); }
}
