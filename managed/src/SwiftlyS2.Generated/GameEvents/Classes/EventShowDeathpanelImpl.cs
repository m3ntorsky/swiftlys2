using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "show_deathpanel"
/// </summary>
internal class EventShowDeathpanelImpl : GameEvent<EventShowDeathpanel>, EventShowDeathpanel
{

  public EventShowDeathpanelImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // endindex of the one who was killed
  public int Victim
  { get => GetPlayerSlot("victim"); set => SetPlayerSlot("victim", value); }

  // entindex of the killer entity
  public nint Killer
  { get => GetPtr("killer"); set => SetPtr("killer", value); }

  public int KillerController
  { get => GetPlayerSlot("killer_controller"); set => SetPlayerSlot("killer_controller", value); }

  public short HitsTaken
  { get => (short)GetInt("hits_taken"); set => SetInt("hits_taken", value); }

  public short DamageTaken
  { get => (short)GetInt("damage_taken"); set => SetInt("damage_taken", value); }

  public short HitsGiven
  { get => (short)GetInt("hits_given"); set => SetInt("hits_given", value); }

  public short DamageGiven
  { get => (short)GetInt("damage_given"); set => SetInt("damage_given", value); }
}
