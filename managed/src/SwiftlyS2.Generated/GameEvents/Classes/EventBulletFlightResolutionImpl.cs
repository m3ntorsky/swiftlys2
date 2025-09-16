using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bullet_flight_resolution"
/// </summary>
internal class EventBulletFlightResolutionImpl : GameEvent<EventBulletFlightResolution>, EventBulletFlightResolution
{

  public EventBulletFlightResolutionImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short PosX
  { get => (short)GetInt("pos_x"); set => SetInt("pos_x", value); }

  public short PosY
  { get => (short)GetInt("pos_y"); set => SetInt("pos_y", value); }

  public short PosZ
  { get => (short)GetInt("pos_z"); set => SetInt("pos_z", value); }

  public short AngX
  { get => (short)GetInt("ang_x"); set => SetInt("ang_x", value); }

  public short AngY
  { get => (short)GetInt("ang_y"); set => SetInt("ang_y", value); }

  public short AngZ
  { get => (short)GetInt("ang_z"); set => SetInt("ang_z", value); }

  public short StartX
  { get => (short)GetInt("start_x"); set => SetInt("start_x", value); }

  public short StartY
  { get => (short)GetInt("start_y"); set => SetInt("start_y", value); }

  public short StartZ
  { get => (short)GetInt("start_z"); set => SetInt("start_z", value); }
}
