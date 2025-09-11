using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerController_ActionTrackingServices : IPlayerControllerComponent {

  
// CUtlVectorEmbeddedNetworkVar< CSPerRoundStats_t >
  public ref CUtlVectorEmbeddedNetworkVar PerRoundStats { get; }
  
  public ISMatchStats_t MatchStats { get; }
  
  public ref int NumRoundKills { get; }
  
  public ref int NumRoundKillsHeadshots { get; }
  
  public ref uint TotalRoundDamageDealt { get; }
}