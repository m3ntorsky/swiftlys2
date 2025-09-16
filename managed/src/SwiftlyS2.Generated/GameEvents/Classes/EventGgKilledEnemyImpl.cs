using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "gg_killed_enemy"
/// </summary>
internal class EventGgKilledEnemyImpl : GameEvent<EventGgKilledEnemy>, EventGgKilledEnemy
{

  public EventGgKilledEnemyImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID who died
  public int VictimID
  { get => GetPlayerSlot("victimid"); set => SetPlayerSlot("victimid", value); }

  // user ID who killed
  public int AttackerID
  { get => GetPlayerSlot("attackerid"); set => SetPlayerSlot("attackerid", value); }

  // did killer dominate victim with this kill
  public short Dominated
  { get => (short)GetInt("dominated"); set => SetInt("dominated", value); }

  // did killer get revenge on victim with this kill
  public short Revenge
  { get => (short)GetInt("revenge"); set => SetInt("revenge", value); }

  // did killer kill with a bonus weapon?
  public bool Bonus
  { get => GetBool("bonus"); set => SetBool("bonus", value); }
}
