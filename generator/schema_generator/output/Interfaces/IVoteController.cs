using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoteController : IBaseEntity {

  
  public ref int ActiveIssueIndex { get; }
  
  public ref int OnlyTeamToVote { get; }
  
  public ISchemaFixedArray<int> VoteOptionCount { get; }
  
  public ref int PotentialVotes { get; }
  
  public ref bool IsYesNoVote { get; }
  
  public ICountdownTimer AcceptingVotesTimer { get; }
  
  public ICountdownTimer ExecuteCommandTimer { get; }
  
  public ICountdownTimer ResetVoteTimer { get; }
  
  public ISchemaFixedArray<int> VotesCast { get; }
  
  public ref CPlayerSlot PlayerHoldingVote { get; }
  
  public ref CPlayerSlot PlayerOverrideForVote { get; }
  
  public ref int HighestCountIndex { get; }
  
  public ref CUtlVector<PointerTo<CBaseIssue>> PotentialIssues { get; }
  
  public ref CUtlVector<PointerTo<CString>> VoteOptions { get; }
}