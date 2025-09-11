using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Test_MultiOutflow_WithParams_Yielding : IPulseCell_BaseYieldingInflow {

  
  public ISignatureOutflow_Continue Out1 { get; }
  
  public ISignatureOutflow_Continue AsyncChild1 { get; }
  
  public ISignatureOutflow_Continue AsyncChild2 { get; }
  
  public ISignatureOutflow_Resume YieldResume1 { get; }
  
  public ISignatureOutflow_Resume YieldResume2 { get; }
}