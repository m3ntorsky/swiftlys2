using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_win_panel_match"
/// </summary>
public interface EventCsWinPanelMatch : ITypedGameEvent<EventCsWinPanelMatch> {

  static EventCsWinPanelMatch ITypedGameEvent<EventCsWinPanelMatch>.Wrap(IGameEvent accessor) => new EventCsWinPanelMatchImpl(accessor);

  static string ITypedGameEvent<EventCsWinPanelMatch>.GetName() => "cs_win_panel_match";

  static uint ITypedGameEvent<EventCsWinPanelMatch>.GetHash() => 0xEEA464A9u;
}
