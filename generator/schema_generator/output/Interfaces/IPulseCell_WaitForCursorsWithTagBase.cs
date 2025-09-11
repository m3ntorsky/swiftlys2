using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_WaitForCursorsWithTagBase : IPulseCell_BaseYieldingInflow {

  
  public ref int CursorsAllowedToWait { get; }
  
  public IPulse_ResumePoint WaitComplete { get; }
}