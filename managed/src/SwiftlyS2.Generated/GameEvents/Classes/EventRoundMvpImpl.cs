using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "round_mvp"
/// </summary>
internal class EventRoundMvpImpl : GameEvent<EventRoundMvp>, EventRoundMvp
{

  public EventRoundMvpImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short Reason
  { get => (short)GetInt("reason"); set => SetInt("reason", value); }

  public int Value
  { get => GetInt("value"); set => SetInt("value", value); }

  public int MusickItMvps
  { get => GetInt("musickitmvps"); set => SetInt("musickitmvps", value); }

  public byte NoMusic
  { get => (byte)GetInt("nomusic"); set => SetInt("nomusic", value); }

  public int MusickItID
  { get => GetInt("musickitid"); set => SetInt("musickitid", value); }
}
