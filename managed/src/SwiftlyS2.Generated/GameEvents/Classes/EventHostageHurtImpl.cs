using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hostage_hurt"
/// </summary>
internal class EventHostageHurtImpl : TypedGameEvent<EventHostageHurt>, EventHostageHurt
{


  // player who hurt the hostage
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // hostage entity index
  public short Hostage
  { get => (short)Accessor.GetInt32("hostage"); set => Accessor.SetInt32("hostage", value); }
}
