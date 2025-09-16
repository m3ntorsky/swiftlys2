using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "instructor_server_hint_create"
/// create a hint using data supplied entirely by the server/map. Intended for hints to smooth playtests before content is ready to make the hint unneccessary. NOT INTENDED AS A SHIPPABLE CRUTCH
/// </summary>
internal class EventInstructorServerHintCreateImpl : GameEvent<EventInstructorServerHintCreate>, EventInstructorServerHintCreate
{

  public EventInstructorServerHintCreateImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID of the player that triggered the hint
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // entity id of the env_instructor_hint that fired the event
  public int HintEntindex
  { get => GetInt("hint_entindex"); set => SetInt("hint_entindex", value); }

  // what to name the hint. For referencing it again later (e.g. a kill command for the hint instead of a timeout)
  public string HintName
  { get => GetString("hint_name"); set => SetString("hint_name", value); }

  // type name so that messages of the same type will replace each other
  public string HintReplaceKey
  { get => GetString("hint_replace_key"); set => SetString("hint_replace_key", value); }

  // entity id that the hint should display at
  public int HintTarget
  { get => GetInt("hint_target"); set => SetInt("hint_target", value); }

  // playerslot of the activator
  public int HintActivatorUserid
  { get => GetPlayerSlot("hint_activator_userid"); set => SetPlayerSlot("hint_activator_userid", value); }

  // how long in seconds until the hint automatically times out, 0 = never
  public short HintTimeout
  { get => (short)GetInt("hint_timeout"); set => SetInt("hint_timeout", value); }

  // the hint icon to use when the hint is onscreen. e.g. "icon_alert_red"
  public string HintIconOnscreen
  { get => GetString("hint_icon_onscreen"); set => SetString("hint_icon_onscreen", value); }

  // the hint icon to use when the hint is offscreen. e.g. "icon_alert"
  public string HintIconOffscreen
  { get => GetString("hint_icon_offscreen"); set => SetString("hint_icon_offscreen", value); }

  // the hint caption. e.g. "#ThisIsDangerous"
  public string HintCaption
  { get => GetString("hint_caption"); set => SetString("hint_caption", value); }

  // the hint caption that only the activator sees e.g. "#YouPushedItGood"
  public string HintActivatorCaption
  { get => GetString("hint_activator_caption"); set => SetString("hint_activator_caption", value); }

  // the hint color in "r,g,b" format where each component is 0-255
  public string HintColor
  { get => GetString("hint_color"); set => SetString("hint_color", value); }

  // how far on the z axis to offset the hint from entity origin
  public float HintIconOffset
  { get => GetFloat("hint_icon_offset"); set => SetFloat("hint_icon_offset", value); }

  // range before the hint is culled
  public float HintRange
  { get => GetFloat("hint_range"); set => SetFloat("hint_range", value); }

  // hint flags
  public int HintFlags
  { get => GetInt("hint_flags"); set => SetInt("hint_flags", value); }

  // bindings to use when use_binding is the onscreen icon
  public string HintBinding
  { get => GetString("hint_binding"); set => SetString("hint_binding", value); }

  // if false, the hint will dissappear if the target entity is invisible
  public bool HintAllowNodrawTarget
  { get => GetBool("hint_allow_nodraw_target"); set => SetBool("hint_allow_nodraw_target", value); }

  // if true, the hint will not show when outside the player view
  public bool HintNooffscreen
  { get => GetBool("hint_nooffscreen"); set => SetBool("hint_nooffscreen", value); }

  // if true, the hint caption will show even if the hint is occluded
  public bool HintForcecaption
  { get => GetBool("hint_forcecaption"); set => SetBool("hint_forcecaption", value); }

  // if true, only the local player will see the hint
  public bool HintLocalPlayerOnly
  { get => GetBool("hint_local_player_only"); set => SetBool("hint_local_player_only", value); }

  // Game sound to play
  public string HintStartSound
  { get => GetString("hint_start_sound"); set => SetString("hint_start_sound", value); }

  // Path for Panorama layout file
  public string HintLayoutfile
  { get => GetString("hint_layoutfile"); set => SetString("hint_layoutfile", value); }

  // Attachment type for the Panorama panel
  public short HintVrPanelType
  { get => (short)GetInt("hint_vr_panel_type"); set => SetInt("hint_vr_panel_type", value); }

  // Height offset for attached panels
  public float HintVrHeightOffset
  { get => GetFloat("hint_vr_height_offset"); set => SetFloat("hint_vr_height_offset", value); }

  // offset for attached panels
  public float HintVrOffsetX
  { get => GetFloat("hint_vr_offset_x"); set => SetFloat("hint_vr_offset_x", value); }

  // offset for attached panels
  public float HintVrOffsetY
  { get => GetFloat("hint_vr_offset_y"); set => SetFloat("hint_vr_offset_y", value); }

  // offset for attached panels
  public float HintVrOffsetZ
  { get => GetFloat("hint_vr_offset_z"); set => SetFloat("hint_vr_offset_z", value); }
}
