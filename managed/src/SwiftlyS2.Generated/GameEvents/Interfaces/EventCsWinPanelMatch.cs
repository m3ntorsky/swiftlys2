using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_win_panel_match"
/// </summary>
public interface EventCsWinPanelMatch : IGameEvent<EventCsWinPanelMatch> {

  static EventCsWinPanelMatch IGameEvent<EventCsWinPanelMatch>.FromAllocated(nint ptr) => new EventCsWinPanelMatchImpl(ptr, true);

  static EventCsWinPanelMatch IGameEvent<EventCsWinPanelMatch>.FromExternal(nint ptr) => new EventCsWinPanelMatchImpl(ptr, false);

  static string IGameEvent<EventCsWinPanelMatch>.GetName() => "cs_win_panel_match";

  static uint IGameEvent<EventCsWinPanelMatch>.GetHash() => 0xEEA464A9u;
}
