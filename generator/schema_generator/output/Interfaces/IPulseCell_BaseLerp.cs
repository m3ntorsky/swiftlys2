using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_BaseLerp : IPulseCell_BaseYieldingInflow {

  
  public IPulse_ResumePoint WakeResume { get; }
}