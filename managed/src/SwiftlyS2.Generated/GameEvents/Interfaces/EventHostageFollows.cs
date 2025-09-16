using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_follows"
/// </summary>
public interface EventHostageFollows : IGameEvent<EventHostageFollows> {

  static EventHostageFollows IGameEvent<EventHostageFollows>.FromAllocated(nint ptr) => new EventHostageFollowsImpl(ptr, true);

  static EventHostageFollows IGameEvent<EventHostageFollows>.FromExternal(nint ptr) => new EventHostageFollowsImpl(ptr, false);

  static string IGameEvent<EventHostageFollows>.GetName() => "hostage_follows";

  static uint IGameEvent<EventHostageFollows>.GetHash() => 0xEC398ED7u;
  /// <summary>
  /// player who touched the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// hostage entity index
  /// <br/>
  /// type: short
  /// </summary>
  short Hostage { get; set; }

}
