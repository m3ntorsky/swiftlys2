using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "drone_above_roof"
/// </summary>
internal class EventDroneAboveRoofImpl : TypedGameEvent<EventDroneAboveRoof>, EventDroneAboveRoof
{

  public EventDroneAboveRoofImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short Cargo
  { get => (short)Accessor.GetInt32("cargo"); set => Accessor.SetInt32("cargo", value); }
}
