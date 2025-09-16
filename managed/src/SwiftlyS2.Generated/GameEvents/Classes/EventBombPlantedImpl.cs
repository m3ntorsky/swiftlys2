using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_planted"
/// </summary>
internal class EventBombPlantedImpl : GameEvent<EventBombPlanted>, EventBombPlanted
{

  public EventBombPlantedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who planted the bomb
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // bombsite index
  public short Site
  { get => (short)GetInt("site"); set => SetInt("site", value); }
}
