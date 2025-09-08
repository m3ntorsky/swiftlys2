using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Inflow_Yield : IPulseCell_BaseYieldingInflow {

  public IPulse_ResumePoint UnyieldResume { get; }
  
}