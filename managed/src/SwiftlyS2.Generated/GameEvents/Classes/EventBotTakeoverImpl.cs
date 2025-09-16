using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bot_takeover"
/// </summary>
internal class EventBotTakeoverImpl : GameEvent<EventBotTakeover>, EventBotTakeover
{

  public EventBotTakeoverImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public int BotID
  { get => GetPlayerSlot("botid"); set => SetPlayerSlot("botid", value); }

  public float P
  { get => GetFloat("p"); set => SetFloat("p", value); }

  public float Y
  { get => GetFloat("y"); set => SetFloat("y", value); }

  public float R
  { get => GetFloat("r"); set => SetFloat("r", value); }
}
