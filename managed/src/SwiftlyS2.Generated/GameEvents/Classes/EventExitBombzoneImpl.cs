using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "exit_bombzone"
/// </summary>
internal class EventExitBombzoneImpl : GameEvent<EventExitBombzone>, EventExitBombzone
{

  public EventExitBombzoneImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public bool HasBomb
  { get => GetBool("hasbomb"); set => SetBool("hasbomb", value); }

  public bool IsPlanted
  { get => GetBool("isplanted"); set => SetBool("isplanted", value); }
}
