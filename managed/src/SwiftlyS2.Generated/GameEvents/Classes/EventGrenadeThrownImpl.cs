using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "grenade_thrown"
/// </summary>
internal class EventGrenadeThrownImpl : TypedGameEvent<EventGrenadeThrown>, EventGrenadeThrown
{

  public EventGrenadeThrownImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // weapon name used
  public string Weapon
  { get => Accessor.GetString("weapon"); set => Accessor.SetString("weapon", value); }
}
