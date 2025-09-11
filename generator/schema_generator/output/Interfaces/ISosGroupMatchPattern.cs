using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupMatchPattern : ISosGroupBranchPattern {

  
  public ref CUtlString MatchSoundEventName { get; }
  
  public ref CUtlString MatchSoundEventSubString { get; }
  
  public ref float EntIndex { get; }
  
  public ref float Opvar { get; }
  
  public ref CUtlString OpvarString { get; }
}