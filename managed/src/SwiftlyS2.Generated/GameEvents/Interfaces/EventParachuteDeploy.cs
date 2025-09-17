using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "parachute_deploy"
/// </summary>
public interface EventParachuteDeploy : ITypedGameEvent<EventParachuteDeploy> {

  static EventParachuteDeploy ITypedGameEvent<EventParachuteDeploy>.Wrap(IGameEvent accessor) => new EventParachuteDeployImpl(accessor);

  static string ITypedGameEvent<EventParachuteDeploy>.GetName() => "parachute_deploy";

  static uint ITypedGameEvent<EventParachuteDeploy>.GetHash() => 0xE34D70F2u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
