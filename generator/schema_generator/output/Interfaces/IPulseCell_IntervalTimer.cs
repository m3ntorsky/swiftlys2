using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_IntervalTimer : IPulseCell_BaseYieldingInflow {

  public IPulse_ResumePoint Completed { get; }
  
  public ISignatureOutflow_Continue OnInterval { get; }
  
}