using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSTeam : ITeam {

  
  public ref int LastRecievedShorthandedRoundBonus { get; }
  
  public ref int ShorthandedRoundBonusStartRound { get; }
  
  public ref bool Surrendered { get; }
  
  public ISchemaFixedString TeamMatchStat { get; }
  
  public ref int NumMapVictories { get; }
  
  public ref int ScoreFirstHalf { get; }
  
  public ref int ScoreSecondHalf { get; }
  
  public ref int ScoreOvertime { get; }
  
  public ISchemaFixedString ClanTeamname { get; }
  
  public ref uint ClanID { get; }
  
  public ISchemaFixedString TeamFlagImage { get; }
  
  public ISchemaFixedString TeamLogoImage { get; }
  
  public ref float NextResourceTime { get; }
  
  public ref int LastUpdateSentAt { get; }
}