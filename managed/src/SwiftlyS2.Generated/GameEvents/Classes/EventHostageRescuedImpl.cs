using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hostage_rescued"
/// </summary>
internal class EventHostageRescuedImpl : GameEvent<EventHostageRescued>, EventHostageRescued
{

  public EventHostageRescuedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who rescued the hostage
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // hostage entity index
  public short Hostage
  { get => (short)GetInt("hostage"); set => SetInt("hostage", value); }

  // rescue site index
  public short Site
  { get => (short)GetInt("site"); set => SetInt("site", value); }
}
