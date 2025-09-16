using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "parachute_deploy"
/// </summary>
public interface EventParachuteDeploy : IGameEvent<EventParachuteDeploy> {

  static EventParachuteDeploy IGameEvent<EventParachuteDeploy>.FromAllocated(nint ptr) => new EventParachuteDeployImpl(ptr, true);

  static EventParachuteDeploy IGameEvent<EventParachuteDeploy>.FromExternal(nint ptr) => new EventParachuteDeployImpl(ptr, false);

  static string IGameEvent<EventParachuteDeploy>.GetName() => "parachute_deploy";

  static uint IGameEvent<EventParachuteDeploy>.GetHash() => 0xE34D70F2u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
