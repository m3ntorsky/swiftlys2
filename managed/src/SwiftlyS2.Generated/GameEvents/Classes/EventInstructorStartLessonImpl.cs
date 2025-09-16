using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "instructor_start_lesson"
/// </summary>
internal class EventInstructorStartLessonImpl : GameEvent<EventInstructorStartLesson>, EventInstructorStartLesson
{

  public EventInstructorStartLessonImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // The player who this lesson is intended for
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // Name of the lesson to start.  Must match instructor_lesson.txt
  public string HintName
  { get => GetString("hint_name"); set => SetString("hint_name", value); }

  // entity id that the hint should display at. Leave empty if controller target
  public int HintTarget
  { get => GetInt("hint_target"); set => SetInt("hint_target", value); }

  public byte VrMovementType
  { get => (byte)GetInt("vr_movement_type"); set => SetInt("vr_movement_type", value); }

  public bool VrSingleController
  { get => GetBool("vr_single_controller"); set => SetBool("vr_single_controller", value); }

  public byte VrControllerType
  { get => (byte)GetInt("vr_controller_type"); set => SetInt("vr_controller_type", value); }
}
