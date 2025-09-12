using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRR_Response : ISchemaClass {

  
  public ref byte Type { get; }
  
  public ISchemaFixedString ResponseName { get; }
  
  public ISchemaFixedString MatchingRule { get; }
  
  public IResponseParams Params { get; }
  
  public ref float MatchScore { get; }
  
  public ref bool AnyMatchingRulesInCooldown { get; }
  
  public ref CString SpeakerContext { get; }
  
  public ref CString WorldContext { get; }
  
  public IResponseFollowup Followup { get; }
  
  public ISchemaUntypedField RecipientFilter { get; }
}