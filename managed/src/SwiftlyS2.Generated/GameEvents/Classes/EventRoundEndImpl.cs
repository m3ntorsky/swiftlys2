using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "round_end"
/// </summary>
internal class EventRoundEndImpl : GameEvent<EventRoundEnd>, EventRoundEnd
{

  public EventRoundEndImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // winner team/user i
  public byte Winner
  { get => (byte)GetInt("winner"); set => SetInt("winner", value); }

  // reson why team won
  public byte Reason
  { get => (byte)GetInt("reason"); set => SetInt("reason", value); }

  // end round message
  public string Message
  { get => GetString("message"); set => SetString("message", value); }

  public float Time
  { get => GetFloat("time"); set => SetFloat("time", value); }

  // server-generated legacy value
  public byte Legacy
  { get => (byte)GetInt("legacy"); set => SetInt("legacy", value); }

  // total number of players alive at the end of round, used for statistics gathering, computed on the server in the event client is in replay when receiving this message
  public short PlayerCount
  { get => (short)GetInt("player_count"); set => SetInt("player_count", value); }

  // if set, don't play round end music, because action is still on-going
  public byte NoMusic
  { get => (byte)GetInt("nomusic"); set => SetInt("nomusic", value); }
}
