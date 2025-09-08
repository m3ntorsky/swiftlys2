using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Test_MultiOutflow_WithParams : IPulseCell_BaseFlow {

  public ISignatureOutflow_Continue Out1 { get; }
  
  public ISignatureOutflow_Continue Out2 { get; }
  
}