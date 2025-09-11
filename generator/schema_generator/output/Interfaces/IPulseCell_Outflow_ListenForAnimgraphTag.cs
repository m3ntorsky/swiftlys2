using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_ListenForAnimgraphTag : IPulseCell_BaseYieldingInflow {

  
  public IPulse_ResumePoint OnStart { get; }
  
  public IPulse_ResumePoint OnEnd { get; }
  
  public IPulse_ResumePoint OnCanceled { get; }
  
  public ref CGlobalSymbol TagName { get; }
}