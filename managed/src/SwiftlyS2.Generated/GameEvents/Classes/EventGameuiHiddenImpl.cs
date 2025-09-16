using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "gameui_hidden"
/// </summary>
internal class EventGameuiHiddenImpl : GameEvent<EventGameuiHidden>, EventGameuiHidden
{

  public EventGameuiHiddenImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // team id
  public byte Team
  { get => (byte)GetInt("team"); set => SetInt("team", value); }

  // old team id
  public byte OldTeam
  { get => (byte)GetInt("oldteam"); set => SetInt("oldteam", value); }

  // team change because player disconnects
  public bool Disconnect
  { get => GetBool("disconnect"); set => SetBool("disconnect", value); }

  public bool Silent
  { get => GetBool("silent"); set => SetBool("silent", value); }

  // true if player is a bot
  public bool IsBot
  { get => GetBool("isbot"); set => SetBool("isbot", value); }

  // true if team only chat
  public bool TeamOnly
  { get => GetBool("teamonly"); set => SetBool("teamonly", value); }

  // chat text
  public string Text
  { get => GetString("text"); set => SetString("text", value); }

  // # of kills
  public short Kills
  { get => (short)GetInt("kills"); set => SetInt("kills", value); }

  // # of deaths
  public short Deaths
  { get => (short)GetInt("deaths"); set => SetInt("deaths", value); }

  // total game score
  public short Score
  { get => (short)GetInt("score"); set => SetInt("score", value); }

  // weapon ID
  public byte Weapon
  { get => (byte)GetInt("weapon"); set => SetInt("weapon", value); }

  // weapon mode
  public byte Mode
  { get => (byte)GetInt("mode"); set => SetInt("mode", value); }

  // map name
  public string MapName
  { get => GetString("mapname"); set => SetString("mapname", value); }

  // max round
  public int RoundsLimit
  { get => GetInt("roundslimit"); set => SetInt("roundslimit", value); }

  // time limit
  public int TimeLimit
  { get => GetInt("timelimit"); set => SetInt("timelimit", value); }

  // frag limit
  public int FragLimit
  { get => GetInt("fraglimit"); set => SetInt("fraglimit", value); }

  // round objective
  public string Objective
  { get => GetString("objective"); set => SetString("objective", value); }

  // winner team/user id
  public byte Winner
  { get => (byte)GetInt("winner"); set => SetInt("winner", value); }

  // reson why team won
  public byte Reason
  { get => (byte)GetInt("reason"); set => SetInt("reason", value); }

  // end round message
  public string Message
  { get => GetString("message"); set => SetString("message", value); }

  // server-generated legacy value
  public byte Legacy
  { get => (byte)GetInt("legacy"); set => SetInt("legacy", value); }

  // id of the associated content package
  public ulong PublishedFileId
  { get => GetUint64("published_file_id"); set => SetUint64("published_file_id", value); }

  public int ErrorCode
  { get => GetInt("error_code"); set => SetInt("error_code", value); }

  // id of this specific content (may be image or map)
  public ulong HContent
  { get => GetUint64("hcontent"); set => SetUint64("hcontent", value); }

  // The length of time that this bonus lasts
  public short Time
  { get => (short)GetInt("time"); set => SetInt("time", value); }

  // Loadout position of the bonus weapon
  public short Pos
  { get => (short)GetInt("Pos"); set => SetInt("Pos", value); }

  // The phase #
  public short Phase
  { get => (short)GetInt("phase"); set => SetInt("phase", value); }

  // Weapon entity index
  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }

  // Entindex of the entity they see
  public short Subject
  { get => (short)GetInt("subject"); set => SetInt("subject", value); }

  // Classname of the entity they see
  public string ClassName
  { get => GetString("classname"); set => SetString("classname", value); }

  // name of the entity they see
  public string EntityName
  { get => GetString("entityname"); set => SetString("entityname", value); }

  // what to name the hint. For referencing it again later (e.g. a kill command for the hint instead of a timeout)
  public string HintName
  { get => GetString("hint_name"); set => SetString("hint_name", value); }

  // type name so that messages of the same type will replace each other
  public string HintReplaceKey
  { get => GetString("hint_replace_key"); set => SetString("hint_replace_key", value); }

  // entity id that the hint should display at
  public int HintTarget
  { get => GetInt("hint_target"); set => SetInt("hint_target", value); }

  // userid id of the activator
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

  // gamepad bindings to use when use_binding is the onscreen icon
  public string HintGamepadBinding
  { get => GetString("hint_gamepad_binding"); set => SetString("hint_gamepad_binding", value); }

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

  // Controller id of user
  public short ControllerId
  { get => (short)GetInt("controllerId"); set => SetInt("controllerId", value); }

  public string Issue
  { get => GetString("issue"); set => SetString("issue", value); }

  public string Param1
  { get => GetString("param1"); set => SetString("param1", value); }

  // entity id of the player who initiated the vote
  public int Initiator
  { get => GetInt("initiator"); set => SetInt("initiator", value); }

  public byte VoteOption1
  { get => (byte)GetInt("vote_option1"); set => SetInt("vote_option1", value); }

  public byte VoteOption2
  { get => (byte)GetInt("vote_option2"); set => SetInt("vote_option2", value); }

  public byte VoteOption3
  { get => (byte)GetInt("vote_option3"); set => SetInt("vote_option3", value); }

  public byte VoteOption4
  { get => (byte)GetInt("vote_option4"); set => SetInt("vote_option4", value); }

  public byte VoteOption5
  { get => (byte)GetInt("vote_option5"); set => SetInt("vote_option5", value); }

  public byte PotentialVotes
  { get => (byte)GetInt("potentialVotes"); set => SetInt("potentialVotes", value); }

  // which option the player voted on
  public byte VoteOption
  { get => (byte)GetInt("vote_option"); set => SetInt("vote_option", value); }

  // Number of options - up to MAX_VOTE_OPTIONS
  public byte Count
  { get => (byte)GetInt("count"); set => SetInt("count", value); }

  public string Option1
  { get => GetString("option1"); set => SetString("option1", value); }

  public string Option2
  { get => GetString("option2"); set => SetString("option2", value); }

  public string Option3
  { get => GetString("option3"); set => SetString("option3", value); }

  public string Option4
  { get => GetString("option4"); set => SetString("option4", value); }

  public string Option5
  { get => GetString("option5"); set => SetString("option5", value); }

  public byte Slot1
  { get => (byte)GetInt("slot1"); set => SetInt("slot1", value); }

  public byte Slot2
  { get => (byte)GetInt("slot2"); set => SetInt("slot2", value); }

  public byte Slot3
  { get => (byte)GetInt("slot3"); set => SetInt("slot3", value); }

  public byte Slot4
  { get => (byte)GetInt("slot4"); set => SetInt("slot4", value); }

  public byte Slot5
  { get => (byte)GetInt("slot5"); set => SetInt("slot5", value); }

  public byte Slot6
  { get => (byte)GetInt("slot6"); set => SetInt("slot6", value); }

  public byte Slot7
  { get => (byte)GetInt("slot7"); set => SetInt("slot7", value); }

  public byte Slot8
  { get => (byte)GetInt("slot8"); set => SetInt("slot8", value); }

  public byte Slot9
  { get => (byte)GetInt("slot9"); set => SetInt("slot9", value); }

  public byte Slot10
  { get => (byte)GetInt("slot10"); set => SetInt("slot10", value); }

  public float PosX
  { get => GetFloat("pos_x"); set => SetFloat("pos_x", value); }

  public float PosY
  { get => GetFloat("pos_y"); set => SetFloat("pos_y", value); }

  public float PosZ
  { get => GetFloat("pos_z"); set => SetFloat("pos_z", value); }

  public int DMgState
  { get => GetInt("dmgstate"); set => SetInt("dmgstate", value); }

  public short Bone
  { get => (short)GetInt("bone"); set => SetInt("bone", value); }

  public short AngX
  { get => (short)GetInt("ang_x"); set => SetInt("ang_x", value); }

  public short AngY
  { get => (short)GetInt("ang_y"); set => SetInt("ang_y", value); }

  public short AngZ
  { get => (short)GetInt("ang_z"); set => SetInt("ang_z", value); }

  public short StartX
  { get => (short)GetInt("start_x"); set => SetInt("start_x", value); }

  public short StartY
  { get => (short)GetInt("start_y"); set => SetInt("start_y", value); }

  public short StartZ
  { get => (short)GetInt("start_z"); set => SetInt("start_z", value); }

  public bool Hit
  { get => GetBool("hit"); set => SetBool("hit", value); }
}
