using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_PlaySequence : IPulseCell_Outflow_PlaySceneBase {

  
  public ref CUtlString ParamSequenceName { get; }
}