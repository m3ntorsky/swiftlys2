using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRetakeGameRules : ISchemaClass {

  
  public ref int MatchSeed { get; }
  
  public ref bool BlockersPresent { get; }
  
  public ref bool RoundInProgress { get; }
  
  public ref int FirstSecondHalfRound { get; }
  
  public ref int BombSite { get; }
}