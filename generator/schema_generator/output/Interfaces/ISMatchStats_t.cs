using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISMatchStats_t : ISPerRoundStats_t {

  
  public ref int Enemy5Ks { get; }
  
  public ref int Enemy4Ks { get; }
  
  public ref int Enemy3Ks { get; }
  
  public ref int EnemyKnifeKills { get; }
  
  public ref int EnemyTaserKills { get; }
  
  public ref int Enemy2Ks { get; }
  
  public ref int Utility_Count { get; }
  
  public ref int Utility_Successes { get; }
  
  public ref int Utility_Enemies { get; }
  
  public ref int Flash_Count { get; }
  
  public ref int Flash_Successes { get; }
  
  public ref int HealthPointsRemovedTotal { get; }
  
  public ref int HealthPointsDealtTotal { get; }
  
  public ref int ShotsFiredTotal { get; }
  
  public ref int ShotsOnTargetTotal { get; }
  
  public ref int I1v1Count { get; }
  
  public ref int I1v1Wins { get; }
  
  public ref int I1v2Count { get; }
  
  public ref int I1v2Wins { get; }
  
  public ref int EntryCount { get; }
  
  public ref int EntryWins { get; }
}