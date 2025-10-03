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

  public EventGameuiHiddenImpl(nint address) : base(address)
  {
  }

  // player
  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  // player
  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  // player
  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  // team id
  public byte Team
  { get => (byte)Accessor.GetInt32("team"); set => Accessor.SetInt32("team", value); }

  // old team id
  public byte OldTeam
  { get => (byte)Accessor.GetInt32("oldteam"); set => Accessor.SetInt32("oldteam", value); }

  // team change because player disconnects
  public bool Disconnect
  { get => Accessor.GetBool("disconnect"); set => Accessor.SetBool("disconnect", value); }

  public bool Silent
  { get => Accessor.GetBool("silent"); set => Accessor.SetBool("silent", value); }

  // true if player is a bot
  public bool IsBot
  { get => Accessor.GetBool("isbot"); set => Accessor.SetBool("isbot", value); }

  // true if team only chat
  public bool TeamOnly
  { get => Accessor.GetBool("teamonly"); set => Accessor.SetBool("teamonly", value); }

  // chat text
  public string Text
  { get => Accessor.GetString("text"); set => Accessor.SetString("text", value); }

  // # of kills
  public short Kills
  { get => (short)Accessor.GetInt32("kills"); set => Accessor.SetInt32("kills", value); }

  // # of deaths
  public short Deaths
  { get => (short)Accessor.GetInt32("deaths"); set => Accessor.SetInt32("deaths", value); }

  // total game score
  public short Score
  { get => (short)Accessor.GetInt32("score"); set => Accessor.SetInt32("score", value); }

  // weapon ID
  public byte Weapon
  { get => (byte)Accessor.GetInt32("weapon"); set => Accessor.SetInt32("weapon", value); }

  // weapon mode
  public byte Mode
  { get => (byte)Accessor.GetInt32("mode"); set => Accessor.SetInt32("mode", value); }

  // map name
  public string MapName
  { get => Accessor.GetString("mapname"); set => Accessor.SetString("mapname", value); }

  // max round
  public int RoundsLimit
  { get => Accessor.GetInt32("roundslimit"); set => Accessor.SetInt32("roundslimit", value); }

  // time limit
  public int TimeLimit
  { get => Accessor.GetInt32("timelimit"); set => Accessor.SetInt32("timelimit", value); }

  // frag limit
  public int FragLimit
  { get => Accessor.GetInt32("fraglimit"); set => Accessor.SetInt32("fraglimit", value); }

  // round objective
  public string Objective
  { get => Accessor.GetString("objective"); set => Accessor.SetString("objective", value); }

  // winner team/user id
  public byte Winner
  { get => (byte)Accessor.GetInt32("winner"); set => Accessor.SetInt32("winner", value); }

  // reson why team won
  public byte Reason
  { get => (byte)Accessor.GetInt32("reason"); set => Accessor.SetInt32("reason", value); }

  // end round message
  public string Message
  { get => Accessor.GetString("message"); set => Accessor.SetString("message", value); }

  // server-generated legacy value
  public byte Legacy
  { get => (byte)Accessor.GetInt32("legacy"); set => Accessor.SetInt32("legacy", value); }

  // id of the associated content package
  public ulong PublishedFileId
  { get => Accessor.GetUInt64("published_file_id"); set => Accessor.SetUInt64("published_file_id", value); }

  public int ErrorCode
  { get => Accessor.GetInt32("error_code"); set => Accessor.SetInt32("error_code", value); }

  // id of this specific content (may be image or map)
  public ulong HContent
  { get => Accessor.GetUInt64("hcontent"); set => Accessor.SetUInt64("hcontent", value); }

  // The length of time that this bonus lasts
  public short Time
  { get => (short)Accessor.GetInt32("time"); set => Accessor.SetInt32("time", value); }

  // Loadout position of the bonus weapon
  public short Pos
  { get => (short)Accessor.GetInt32("Pos"); set => Accessor.SetInt32("Pos", value); }

  // The phase #
  public short Phase
  { get => (short)Accessor.GetInt32("phase"); set => Accessor.SetInt32("phase", value); }

  // Weapon entity index
  public int EntIndex
  { get => Accessor.GetInt32("entindex"); set => Accessor.SetInt32("entindex", value); }

  // Entindex of the entity they see
  public short Subject
  { get => (short)Accessor.GetInt32("subject"); set => Accessor.SetInt32("subject", value); }

  // Classname of the entity they see
  public string ClassName
  { get => Accessor.GetString("classname"); set => Accessor.SetString("classname", value); }

  // name of the entity they see
  public string EntityName
  { get => Accessor.GetString("entityname"); set => Accessor.SetString("entityname", value); }

  // what to name the hint. For referencing it again later (e.g. a kill command for the hint instead of a timeout)
  public string HintName
  { get => Accessor.GetString("hint_name"); set => Accessor.SetString("hint_name", value); }

  // type name so that messages of the same type will replace each other
  public string HintReplaceKey
  { get => Accessor.GetString("hint_replace_key"); set => Accessor.SetString("hint_replace_key", value); }

  // entity id that the hint should display at
  public int HintTarget
  { get => Accessor.GetInt32("hint_target"); set => Accessor.SetInt32("hint_target", value); }

  // userid id of the activator
  public int HintActivatorUserid
  { get => Accessor.GetPlayerSlot("hint_activator_userid"); set => Accessor.SetPlayerSlot("hint_activator_userid", value); }

  // how long in seconds until the hint automatically times out, 0 = never
  public short HintTimeout
  { get => (short)Accessor.GetInt32("hint_timeout"); set => Accessor.SetInt32("hint_timeout", value); }

  // the hint icon to use when the hint is onscreen. e.g. "icon_alert_red"
  public string HintIconOnscreen
  { get => Accessor.GetString("hint_icon_onscreen"); set => Accessor.SetString("hint_icon_onscreen", value); }

  // the hint icon to use when the hint is offscreen. e.g. "icon_alert"
  public string HintIconOffscreen
  { get => Accessor.GetString("hint_icon_offscreen"); set => Accessor.SetString("hint_icon_offscreen", value); }

  // the hint caption. e.g. "#ThisIsDangerous"
  public string HintCaption
  { get => Accessor.GetString("hint_caption"); set => Accessor.SetString("hint_caption", value); }

  // the hint caption that only the activator sees e.g. "#YouPushedItGood"
  public string HintActivatorCaption
  { get => Accessor.GetString("hint_activator_caption"); set => Accessor.SetString("hint_activator_caption", value); }

  // the hint color in "r,g,b" format where each component is 0-255
  public string HintColor
  { get => Accessor.GetString("hint_color"); set => Accessor.SetString("hint_color", value); }

  // how far on the z axis to offset the hint from entity origin
  public float HintIconOffset
  { get => Accessor.GetFloat("hint_icon_offset"); set => Accessor.SetFloat("hint_icon_offset", value); }

  // range before the hint is culled
  public float HintRange
  { get => Accessor.GetFloat("hint_range"); set => Accessor.SetFloat("hint_range", value); }

  // hint flags
  public int HintFlags
  { get => Accessor.GetInt32("hint_flags"); set => Accessor.SetInt32("hint_flags", value); }

  // bindings to use when use_binding is the onscreen icon
  public string HintBinding
  { get => Accessor.GetString("hint_binding"); set => Accessor.SetString("hint_binding", value); }

  // gamepad bindings to use when use_binding is the onscreen icon
  public string HintGamepadBinding
  { get => Accessor.GetString("hint_gamepad_binding"); set => Accessor.SetString("hint_gamepad_binding", value); }

  // if false, the hint will dissappear if the target entity is invisible
  public bool HintAllowNodrawTarget
  { get => Accessor.GetBool("hint_allow_nodraw_target"); set => Accessor.SetBool("hint_allow_nodraw_target", value); }

  // if true, the hint will not show when outside the player view
  public bool HintNooffscreen
  { get => Accessor.GetBool("hint_nooffscreen"); set => Accessor.SetBool("hint_nooffscreen", value); }

  // if true, the hint caption will show even if the hint is occluded
  public bool HintForcecaption
  { get => Accessor.GetBool("hint_forcecaption"); set => Accessor.SetBool("hint_forcecaption", value); }

  // if true, only the local player will see the hint
  public bool HintLocalPlayerOnly
  { get => Accessor.GetBool("hint_local_player_only"); set => Accessor.SetBool("hint_local_player_only", value); }

  // Controller id of user
  public short ControllerId
  { get => (short)Accessor.GetInt32("controllerId"); set => Accessor.SetInt32("controllerId", value); }

  public string Issue
  { get => Accessor.GetString("issue"); set => Accessor.SetString("issue", value); }

  public string Param1
  { get => Accessor.GetString("param1"); set => Accessor.SetString("param1", value); }

  // entity id of the player who initiated the vote
  public int Initiator
  { get => Accessor.GetInt32("initiator"); set => Accessor.SetInt32("initiator", value); }

  public byte VoteOption1
  { get => (byte)Accessor.GetInt32("vote_option1"); set => Accessor.SetInt32("vote_option1", value); }

  public byte VoteOption2
  { get => (byte)Accessor.GetInt32("vote_option2"); set => Accessor.SetInt32("vote_option2", value); }

  public byte VoteOption3
  { get => (byte)Accessor.GetInt32("vote_option3"); set => Accessor.SetInt32("vote_option3", value); }

  public byte VoteOption4
  { get => (byte)Accessor.GetInt32("vote_option4"); set => Accessor.SetInt32("vote_option4", value); }

  public byte VoteOption5
  { get => (byte)Accessor.GetInt32("vote_option5"); set => Accessor.SetInt32("vote_option5", value); }

  public byte PotentialVotes
  { get => (byte)Accessor.GetInt32("potentialVotes"); set => Accessor.SetInt32("potentialVotes", value); }

  // which option the player voted on
  public byte VoteOption
  { get => (byte)Accessor.GetInt32("vote_option"); set => Accessor.SetInt32("vote_option", value); }

  // Number of options - up to MAX_VOTE_OPTIONS
  public byte Count
  { get => (byte)Accessor.GetInt32("count"); set => Accessor.SetInt32("count", value); }

  public string Option1
  { get => Accessor.GetString("option1"); set => Accessor.SetString("option1", value); }

  public string Option2
  { get => Accessor.GetString("option2"); set => Accessor.SetString("option2", value); }

  public string Option3
  { get => Accessor.GetString("option3"); set => Accessor.SetString("option3", value); }

  public string Option4
  { get => Accessor.GetString("option4"); set => Accessor.SetString("option4", value); }

  public string Option5
  { get => Accessor.GetString("option5"); set => Accessor.SetString("option5", value); }

  public byte Slot1
  { get => (byte)Accessor.GetInt32("slot1"); set => Accessor.SetInt32("slot1", value); }

  public byte Slot2
  { get => (byte)Accessor.GetInt32("slot2"); set => Accessor.SetInt32("slot2", value); }

  public byte Slot3
  { get => (byte)Accessor.GetInt32("slot3"); set => Accessor.SetInt32("slot3", value); }

  public byte Slot4
  { get => (byte)Accessor.GetInt32("slot4"); set => Accessor.SetInt32("slot4", value); }

  public byte Slot5
  { get => (byte)Accessor.GetInt32("slot5"); set => Accessor.SetInt32("slot5", value); }

  public byte Slot6
  { get => (byte)Accessor.GetInt32("slot6"); set => Accessor.SetInt32("slot6", value); }

  public byte Slot7
  { get => (byte)Accessor.GetInt32("slot7"); set => Accessor.SetInt32("slot7", value); }

  public byte Slot8
  { get => (byte)Accessor.GetInt32("slot8"); set => Accessor.SetInt32("slot8", value); }

  public byte Slot9
  { get => (byte)Accessor.GetInt32("slot9"); set => Accessor.SetInt32("slot9", value); }

  public byte Slot10
  { get => (byte)Accessor.GetInt32("slot10"); set => Accessor.SetInt32("slot10", value); }

  public float PosX
  { get => Accessor.GetFloat("pos_x"); set => Accessor.SetFloat("pos_x", value); }

  public float PosY
  { get => Accessor.GetFloat("pos_y"); set => Accessor.SetFloat("pos_y", value); }

  public float PosZ
  { get => Accessor.GetFloat("pos_z"); set => Accessor.SetFloat("pos_z", value); }

  public int DMgState
  { get => Accessor.GetInt32("dmgstate"); set => Accessor.SetInt32("dmgstate", value); }

  public short Bone
  { get => (short)Accessor.GetInt32("bone"); set => Accessor.SetInt32("bone", value); }

  public short AngX
  { get => (short)Accessor.GetInt32("ang_x"); set => Accessor.SetInt32("ang_x", value); }

  public short AngY
  { get => (short)Accessor.GetInt32("ang_y"); set => Accessor.SetInt32("ang_y", value); }

  public short AngZ
  { get => (short)Accessor.GetInt32("ang_z"); set => Accessor.SetInt32("ang_z", value); }

  public short StartX
  { get => (short)Accessor.GetInt32("start_x"); set => Accessor.SetInt32("start_x", value); }

  public short StartY
  { get => (short)Accessor.GetInt32("start_y"); set => Accessor.SetInt32("start_y", value); }

  public short StartZ
  { get => (short)Accessor.GetInt32("start_z"); set => Accessor.SetInt32("start_z", value); }

  public bool Hit
  { get => Accessor.GetBool("hit"); set => Accessor.SetBool("hit", value); }
}
