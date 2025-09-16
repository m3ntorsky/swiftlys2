using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_chase"
/// shot of a single entity
/// </summary>
internal class EventHltvChaseImpl : GameEvent<EventHltvChase>, EventHltvChase
{

  public EventHltvChaseImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // primary traget index
  public int Target1
  { get => GetPlayerSlot("target1"); set => SetPlayerSlot("target1", value); }

  // secondary traget index or 0
  public int Target2
  { get => GetPlayerSlot("target2"); set => SetPlayerSlot("target2", value); }

  // camera distance
  public short Distance
  { get => (short)GetInt("distance"); set => SetInt("distance", value); }

  // view angle horizontal
  public short Theta
  { get => (short)GetInt("theta"); set => SetInt("theta", value); }

  // view angle vertical
  public short Phi
  { get => (short)GetInt("phi"); set => SetInt("phi", value); }

  // camera inertia
  public byte Inertia
  { get => (byte)GetInt("inertia"); set => SetInt("inertia", value); }

  // diretcor suggests to show ineye
  public byte InEye
  { get => (byte)GetInt("ineye"); set => SetInt("ineye", value); }
}
