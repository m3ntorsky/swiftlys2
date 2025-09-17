using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bot_takeover"
/// </summary>
internal class EventBotTakeoverImpl : TypedGameEvent<EventBotTakeover>, EventBotTakeover
{

  public EventBotTakeoverImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public int BotID
  { get => Accessor.GetPlayerSlot("botid"); set => Accessor.SetPlayerSlot("botid", value); }

  public float P
  { get => Accessor.GetFloat("p"); set => Accessor.SetFloat("p", value); }

  public float Y
  { get => Accessor.GetFloat("y"); set => Accessor.SetFloat("y", value); }

  public float R
  { get => Accessor.GetFloat("r"); set => Accessor.SetFloat("r", value); }
}
