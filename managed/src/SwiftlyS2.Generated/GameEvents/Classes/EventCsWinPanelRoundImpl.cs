using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "cs_win_panel_round"
/// </summary>
internal class EventCsWinPanelRoundImpl : GameEvent<EventCsWinPanelRound>, EventCsWinPanelRound
{

  public EventCsWinPanelRoundImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public bool ShowTimerDefend
  { get => GetBool("show_timer_defend"); set => SetBool("show_timer_defend", value); }

  public bool ShowTimerAttack
  { get => GetBool("show_timer_attack"); set => SetBool("show_timer_attack", value); }

  public short TimerTime
  { get => (short)GetInt("timer_time"); set => SetInt("timer_time", value); }

  // define in cs_gamerules.h
  public byte FinalEvent
  { get => (byte)GetInt("final_event"); set => SetInt("final_event", value); }

  public string FunfactToken
  { get => GetString("funfact_token"); set => SetString("funfact_token", value); }

  public int FunfactPlayer
  { get => GetPlayerSlot("funfact_player"); set => SetPlayerSlot("funfact_player", value); }

  public int FunfactData1
  { get => GetInt("funfact_data1"); set => SetInt("funfact_data1", value); }

  public int FunfactData2
  { get => GetInt("funfact_data2"); set => SetInt("funfact_data2", value); }

  public int FunfactData3
  { get => GetInt("funfact_data3"); set => SetInt("funfact_data3", value); }
}
