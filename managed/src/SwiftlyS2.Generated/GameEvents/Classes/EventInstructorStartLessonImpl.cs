using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "instructor_start_lesson"
/// </summary>
internal class EventInstructorStartLessonImpl : TypedGameEvent<EventInstructorStartLesson>, EventInstructorStartLesson
{


  // The player who this lesson is intended for
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // Name of the lesson to start.  Must match instructor_lesson.txt
  public string HintName
  { get => Accessor.GetString("hint_name"); set => Accessor.SetString("hint_name", value); }

  // entity id that the hint should display at. Leave empty if controller target
  public int HintTarget
  { get => Accessor.GetInt32("hint_target"); set => Accessor.SetInt32("hint_target", value); }

  public byte VrMovementType
  { get => (byte)Accessor.GetInt32("vr_movement_type"); set => Accessor.SetInt32("vr_movement_type", value); }

  public bool VrSingleController
  { get => Accessor.GetBool("vr_single_controller"); set => Accessor.SetBool("vr_single_controller", value); }

  public byte VrControllerType
  { get => (byte)Accessor.GetInt32("vr_controller_type"); set => Accessor.SetInt32("vr_controller_type", value); }
}
