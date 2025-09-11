using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosSoundEventGroupSchema : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref SosGroupType_t Type { get; }
  
  public ref bool IsBlocking { get; }
  
  public ref int BlockMaxCount { get; }
  
  public ref bool InvertMatch { get; }
  
  public ISosGroupMatchPattern MatchPattern { get; }
  
  public ISosGroupBranchPattern BranchPattern { get; }
  
  public ref float LifeSpanTime { get; }
  
  public ISosGroupActionSchema Actions { get; }
}