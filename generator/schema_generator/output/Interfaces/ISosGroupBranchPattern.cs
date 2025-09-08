using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupBranchPattern : ISchemaClass {

  public ref bool MatchEventName { get; }
  
  public ref bool MatchEventSubString { get; }
  
  public ref bool MatchEntIndex { get; }
  
  public ref bool MatchOpvar { get; }
  
  public ref bool MatchString { get; }
  
}