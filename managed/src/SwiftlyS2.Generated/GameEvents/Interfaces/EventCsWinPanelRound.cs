using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_win_panel_round"
/// </summary>
public interface EventCsWinPanelRound : IGameEvent<EventCsWinPanelRound> {

  static EventCsWinPanelRound IGameEvent<EventCsWinPanelRound>.FromAllocated(nint ptr) => new EventCsWinPanelRoundImpl(ptr, true);

  static EventCsWinPanelRound IGameEvent<EventCsWinPanelRound>.FromExternal(nint ptr) => new EventCsWinPanelRoundImpl(ptr, false);

  static string IGameEvent<EventCsWinPanelRound>.GetName() => "cs_win_panel_round";

  static uint IGameEvent<EventCsWinPanelRound>.GetHash() => 0xFF5D5EC0u;
  /// <summary>
  /// type: bool
  /// </summary>
  bool ShowTimerDefend { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool ShowTimerAttack { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short TimerTime { get; set; }

  /// <summary>
  /// define in cs_gamerules.h
  /// <br/>
  /// type: byte
  /// </summary>
  byte FinalEvent { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string FunfactToken { get; set; }

  /// <summary>
  /// type: player_controller
  /// </summary>
  int FunfactPlayer { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int FunfactData1 { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int FunfactData2 { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int FunfactData3 { get; set; }

}
