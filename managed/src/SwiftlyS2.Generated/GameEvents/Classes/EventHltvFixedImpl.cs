using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_fixed"
/// show from fixed view
/// </summary>
internal class EventHltvFixedImpl : GameEvent<EventHltvFixed>, EventHltvFixed
{

  public EventHltvFixedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // camera position in world
  public int PosX
  { get => GetInt("posx"); set => SetInt("posx", value); }

  public int Posy
  { get => GetInt("posy"); set => SetInt("posy", value); }

  public int PosZ
  { get => GetInt("posz"); set => SetInt("posz", value); }

  // camera angles
  public short Theta
  { get => (short)GetInt("theta"); set => SetInt("theta", value); }

  public short Phi
  { get => (short)GetInt("phi"); set => SetInt("phi", value); }

  public short Offset
  { get => (short)GetInt("offset"); set => SetInt("offset", value); }

  public float FOv
  { get => GetFloat("fov"); set => SetFloat("fov", value); }

  // follow this player
  public int Target
  { get => GetPlayerSlot("target"); set => SetPlayerSlot("target", value); }
}
