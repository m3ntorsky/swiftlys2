using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionMemberCountEnvelopeSchema : ISosGroupActionSchema {

  
  public ref int BaseCount { get; }
  
  public ref int TargetCount { get; }
  
  public ref float BaseValue { get; }
  
  public ref float TargetValue { get; }
  
  public ref float Attack { get; }
  
  public ref float Decay { get; }
  
  public ref CUtlString ResultVarName { get; }
  
  public ref bool SaveToGroup { get; }
}