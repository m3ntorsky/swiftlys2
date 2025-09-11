using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISAdditionalMatchStats_t : ISAdditionalPerRoundStats_t {

  
  public ref int NumRoundsSurvived { get; }
  
  public ref int MaxNumRoundsSurvived { get; }
  
  public ref int NumRoundsSurvivedTotal { get; }
  
  public ref int RoundsWonWithoutPurchase { get; }
  
  public ref int RoundsWonWithoutPurchaseTotal { get; }
  
  public ref int NumFirstKills { get; }
  
  public ref int NumClutchKills { get; }
  
  public ref int NumPistolKills { get; }
  
  public ref int NumSniperKills { get; }
  
  public ref int NumSuicides { get; }
  
  public ref int NumTeamKills { get; }
  
  public ref int TeamDamage { get; }
}