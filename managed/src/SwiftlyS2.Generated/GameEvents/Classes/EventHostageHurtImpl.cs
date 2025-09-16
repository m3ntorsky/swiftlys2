using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hostage_hurt"
/// </summary>
internal class EventHostageHurtImpl : GameEvent<EventHostageHurt>, EventHostageHurt
{

  public EventHostageHurtImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who hurt the hostage
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // hostage entity index
  public short Hostage
  { get => (short)GetInt("hostage"); set => SetInt("hostage", value); }
}
