using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseIssue : ISchemaClass {

  
  public ISchemaFixedString TypeString { get; }
  
  public ISchemaFixedString DetailsString { get; }
  
  public ref int NumYesVotes { get; }
  
  public ref int NumNoVotes { get; }
  
  public ref int NumPotentialVotes { get; }
  
  public IVoteController VoteController { get; }
}