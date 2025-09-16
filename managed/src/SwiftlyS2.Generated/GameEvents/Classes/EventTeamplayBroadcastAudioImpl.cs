using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "teamplay_broadcast_audio"
/// emits a sound to everyone on a team
/// </summary>
internal class EventTeamplayBroadcastAudioImpl : GameEvent<EventTeamplayBroadcastAudio>, EventTeamplayBroadcastAudio
{

  public EventTeamplayBroadcastAudioImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // unique team id
  public byte Team
  { get => (byte)GetInt("team"); set => SetInt("team", value); }

  // name of the sound to emit
  public string Sound
  { get => GetString("sound"); set => SetString("sound", value); }
}
