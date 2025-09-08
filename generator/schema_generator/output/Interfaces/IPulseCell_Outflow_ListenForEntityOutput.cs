using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_ListenForEntityOutput : IPulseCell_BaseYieldingInflow {

  public ISignatureOutflow_Resume OnFired { get; }
  
  public IPulse_ResumePoint OnCanceled { get; }
  
  public ref CGlobalSymbol StrEntityOutput { get; }
  
  public ref CUtlString StrEntityOutputParam { get; }
  
  public ref bool ListenUntilCanceled { get; }
  
}