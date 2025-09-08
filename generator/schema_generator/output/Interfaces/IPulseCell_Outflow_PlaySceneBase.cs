using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_PlaySceneBase : IPulseCell_BaseYieldingInflow {

  public IPulse_ResumePoint OnFinished { get; }
  
  public IPulse_ResumePoint OnCanceled { get; }
  
  public ref CUtlVector Triggers { get; }
  
}