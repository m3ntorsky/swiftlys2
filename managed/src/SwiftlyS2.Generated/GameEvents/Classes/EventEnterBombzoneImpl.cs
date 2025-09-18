using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "enter_bombzone"
/// </summary>
internal class EventEnterBombzoneImpl : GameEvent<EventEnterBombzone>, EventEnterBombzone
{


  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  public bool HasBomb
  { get => Accessor.GetBool("hasbomb"); set => Accessor.SetBool("hasbomb", value); }

  public bool IsPlanted
  { get => Accessor.GetBool("isplanted"); set => Accessor.SetBool("isplanted", value); }
}
