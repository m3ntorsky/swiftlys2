using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "enter_bombzone"
/// </summary>
internal class EventEnterBombzoneImpl : TypedGameEvent<EventEnterBombzone>, EventEnterBombzone
{

  public EventEnterBombzoneImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public bool HasBomb
  { get => Accessor.GetBool("hasbomb"); set => Accessor.SetBool("hasbomb", value); }

  public bool IsPlanted
  { get => Accessor.GetBool("isplanted"); set => Accessor.SetBool("isplanted", value); }
}
