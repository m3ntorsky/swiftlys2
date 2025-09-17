using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "round_mvp"
/// </summary>
internal class EventRoundMvpImpl : TypedGameEvent<EventRoundMvp>, EventRoundMvp
{

  public EventRoundMvpImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short Reason
  { get => (short)Accessor.GetInt32("reason"); set => Accessor.SetInt32("reason", value); }

  public int Value
  { get => Accessor.GetInt32("value"); set => Accessor.SetInt32("value", value); }

  public int MusickItMvps
  { get => Accessor.GetInt32("musickitmvps"); set => Accessor.SetInt32("musickitmvps", value); }

  public byte NoMusic
  { get => (byte)Accessor.GetInt32("nomusic"); set => Accessor.SetInt32("nomusic", value); }

  public int MusickItID
  { get => Accessor.GetInt32("musickitid"); set => Accessor.SetInt32("musickitid", value); }
}
