using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "gameui_hidden"
/// </summary>
public interface EventGameuiHidden : IGameEvent<EventGameuiHidden> {

  static EventGameuiHidden IGameEvent<EventGameuiHidden>.Create() => new EventGameuiHiddenImpl();

  static string IGameEvent<EventGameuiHidden>.GetName() => "gameui_hidden";

  static uint IGameEvent<EventGameuiHidden>.GetHash() => 0xB938FB5Eu;
  /// <summary>
  /// player
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// player
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// player
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  int UserId { get; set; }

  /// <summary>
  /// team id
  /// <br/>
  /// type: byte
  /// </summary>
  byte Team { get; set; }

  /// <summary>
  /// old team id
  /// <br/>
  /// type: byte
  /// </summary>
  byte OldTeam { get; set; }

  /// <summary>
  /// team change because player disconnects
  /// <br/>
  /// type: bool
  /// </summary>
  bool Disconnect { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Silent { get; set; }

  /// <summary>
  /// true if player is a bot
  /// <br/>
  /// type: bool
  /// </summary>
  bool IsBot { get; set; }

  /// <summary>
  /// true if team only chat
  /// <br/>
  /// type: bool
  /// </summary>
  bool TeamOnly { get; set; }

  /// <summary>
  /// chat text
  /// <br/>
  /// type: string
  /// </summary>
  string Text { get; set; }

  /// <summary>
  /// # of kills
  /// <br/>
  /// type: short
  /// </summary>
  short Kills { get; set; }

  /// <summary>
  /// # of deaths
  /// <br/>
  /// type: short
  /// </summary>
  short Deaths { get; set; }

  /// <summary>
  /// total game score
  /// <br/>
  /// type: short
  /// </summary>
  short Score { get; set; }

  /// <summary>
  /// weapon ID
  /// <br/>
  /// type: byte
  /// </summary>
  byte Weapon { get; set; }

  /// <summary>
  /// weapon mode
  /// <br/>
  /// type: byte
  /// </summary>
  byte Mode { get; set; }

  /// <summary>
  /// map name
  /// <br/>
  /// type: string
  /// </summary>
  string MapName { get; set; }

  /// <summary>
  /// max round
  /// <br/>
  /// type: long
  /// </summary>
  int RoundsLimit { get; set; }

  /// <summary>
  /// time limit
  /// <br/>
  /// type: long
  /// </summary>
  int TimeLimit { get; set; }

  /// <summary>
  /// frag limit
  /// <br/>
  /// type: long
  /// </summary>
  int FragLimit { get; set; }

  /// <summary>
  /// round objective
  /// <br/>
  /// type: string
  /// </summary>
  string Objective { get; set; }

  /// <summary>
  /// winner team/user id
  /// <br/>
  /// type: byte
  /// </summary>
  byte Winner { get; set; }

  /// <summary>
  /// reson why team won
  /// <br/>
  /// type: byte
  /// </summary>
  byte Reason { get; set; }

  /// <summary>
  /// end round message
  /// <br/>
  /// type: string
  /// </summary>
  string Message { get; set; }

  /// <summary>
  /// server-generated legacy value
  /// <br/>
  /// type: byte
  /// </summary>
  byte Legacy { get; set; }

  /// <summary>
  /// id of the associated content package
  /// <br/>
  /// type: uint64
  /// </summary>
  ulong PublishedFileId { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int ErrorCode { get; set; }

  /// <summary>
  /// id of this specific content (may be image or map)
  /// <br/>
  /// type: uint64
  /// </summary>
  ulong HContent { get; set; }

  /// <summary>
  /// The length of time that this bonus lasts
  /// <br/>
  /// type: short
  /// </summary>
  short Time { get; set; }

  /// <summary>
  /// Loadout position of the bonus weapon
  /// <br/>
  /// type: short
  /// </summary>
  short Pos { get; set; }

  /// <summary>
  /// The phase #
  /// <br/>
  /// type: short
  /// </summary>
  short Phase { get; set; }

  /// <summary>
  /// Weapon entity index
  /// <br/>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

  /// <summary>
  /// Entindex of the entity they see
  /// <br/>
  /// type: short
  /// </summary>
  short Subject { get; set; }

  /// <summary>
  /// Classname of the entity they see
  /// <br/>
  /// type: string
  /// </summary>
  string ClassName { get; set; }

  /// <summary>
  /// name of the entity they see
  /// <br/>
  /// type: string
  /// </summary>
  string EntityName { get; set; }

  /// <summary>
  /// what to name the hint. For referencing it again later (e.g. a kill command for the hint instead of a timeout)
  /// <br/>
  /// type: string
  /// </summary>
  string HintName { get; set; }

  /// <summary>
  /// type name so that messages of the same type will replace each other
  /// <br/>
  /// type: string
  /// </summary>
  string HintReplaceKey { get; set; }

  /// <summary>
  /// entity id that the hint should display at
  /// <br/>
  /// type: long
  /// </summary>
  int HintTarget { get; set; }

  /// <summary>
  /// userid id of the activator
  /// <br/>
  /// type: player_controller
  /// </summary>
  int HintActivatorUserid { get; set; }

  /// <summary>
  /// how long in seconds until the hint automatically times out, 0 = never
  /// <br/>
  /// type: short
  /// </summary>
  short HintTimeout { get; set; }

  /// <summary>
  /// the hint icon to use when the hint is onscreen. e.g. "icon_alert_red"
  /// <br/>
  /// type: string
  /// </summary>
  string HintIconOnscreen { get; set; }

  /// <summary>
  /// the hint icon to use when the hint is offscreen. e.g. "icon_alert"
  /// <br/>
  /// type: string
  /// </summary>
  string HintIconOffscreen { get; set; }

  /// <summary>
  /// the hint caption. e.g. "#ThisIsDangerous"
  /// <br/>
  /// type: string
  /// </summary>
  string HintCaption { get; set; }

  /// <summary>
  /// the hint caption that only the activator sees e.g. "#YouPushedItGood"
  /// <br/>
  /// type: string
  /// </summary>
  string HintActivatorCaption { get; set; }

  /// <summary>
  /// the hint color in "r,g,b" format where each component is 0-255
  /// <br/>
  /// type: string
  /// </summary>
  string HintColor { get; set; }

  /// <summary>
  /// how far on the z axis to offset the hint from entity origin
  /// <br/>
  /// type: float
  /// </summary>
  float HintIconOffset { get; set; }

  /// <summary>
  /// range before the hint is culled
  /// <br/>
  /// type: float
  /// </summary>
  float HintRange { get; set; }

  /// <summary>
  /// hint flags
  /// <br/>
  /// type: long
  /// </summary>
  int HintFlags { get; set; }

  /// <summary>
  /// bindings to use when use_binding is the onscreen icon
  /// <br/>
  /// type: string
  /// </summary>
  string HintBinding { get; set; }

  /// <summary>
  /// gamepad bindings to use when use_binding is the onscreen icon
  /// <br/>
  /// type: string
  /// </summary>
  string HintGamepadBinding { get; set; }

  /// <summary>
  /// if false, the hint will dissappear if the target entity is invisible
  /// <br/>
  /// type: bool
  /// </summary>
  bool HintAllowNodrawTarget { get; set; }

  /// <summary>
  /// if true, the hint will not show when outside the player view
  /// <br/>
  /// type: bool
  /// </summary>
  bool HintNooffscreen { get; set; }

  /// <summary>
  /// if true, the hint caption will show even if the hint is occluded
  /// <br/>
  /// type: bool
  /// </summary>
  bool HintForcecaption { get; set; }

  /// <summary>
  /// if true, only the local player will see the hint
  /// <br/>
  /// type: bool
  /// </summary>
  bool HintLocalPlayerOnly { get; set; }

  /// <summary>
  /// Controller id of user
  /// <br/>
  /// type: short
  /// </summary>
  short ControllerId { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Issue { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Param1 { get; set; }

  /// <summary>
  /// entity id of the player who initiated the vote
  /// <br/>
  /// type: long
  /// </summary>
  int Initiator { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte VoteOption1 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte VoteOption2 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte VoteOption3 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte VoteOption4 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte VoteOption5 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte PotentialVotes { get; set; }

  /// <summary>
  /// which option the player voted on
  /// <br/>
  /// type: byte
  /// </summary>
  byte VoteOption { get; set; }

  /// <summary>
  /// Number of options - up to MAX_VOTE_OPTIONS
  /// <br/>
  /// type: byte
  /// </summary>
  byte Count { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Option1 { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Option2 { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Option3 { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Option4 { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Option5 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot1 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot2 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot3 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot4 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot5 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot6 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot7 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot8 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot9 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Slot10 { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float PosX { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float PosY { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float PosZ { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int DMgState { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Bone { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short AngX { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short AngY { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short AngZ { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short StartX { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short StartY { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short StartZ { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Hit { get; set; }

}
