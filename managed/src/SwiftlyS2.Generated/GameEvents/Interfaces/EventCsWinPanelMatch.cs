using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_win_panel_match"
/// </summary>
public interface EventCsWinPanelMatch : IGameEvent<EventCsWinPanelMatch> {

  static EventCsWinPanelMatch IGameEvent<EventCsWinPanelMatch>.Create() => new EventCsWinPanelMatchImpl();

  static string IGameEvent<EventCsWinPanelMatch>.GetName() => "cs_win_panel_match";

  static uint IGameEvent<EventCsWinPanelMatch>.GetHash() => 0xEEA464A9u;
}
