using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "set_instructor_group_enabled"
/// </summary>
public interface EventSetInstructorGroupEnabled : ITypedGameEvent<EventSetInstructorGroupEnabled> {

  static EventSetInstructorGroupEnabled ITypedGameEvent<EventSetInstructorGroupEnabled>.Wrap(IGameEvent accessor) => new EventSetInstructorGroupEnabledImpl(accessor);

  static string ITypedGameEvent<EventSetInstructorGroupEnabled>.GetName() => "set_instructor_group_enabled";

  static uint ITypedGameEvent<EventSetInstructorGroupEnabled>.GetHash() => 0x87A9E425u;
  /// <summary>
  /// type: string
  /// </summary>
  string Group { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Enabled { get; set; }

}
