using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Test_MultiOutflow_WithParams_Yielding : CPulseCell_BaseYieldingInflow, IPulseCell_Test_MultiOutflow_WithParams_Yielding {

  public CPulseCell_Test_MultiOutflow_WithParams_Yielding(nint handle) : base(handle) {
  }

  public ISignatureOutflow_Continue Out1 {
    get => new SignatureOutflow_Continue(_Handle + Schema.GetOffset(0xB412A25905F293AA));
  }
  public ISignatureOutflow_Continue AsyncChild1 {
    get => new SignatureOutflow_Continue(_Handle + Schema.GetOffset(0xB412A2592CEBF78A));
  }
  public ISignatureOutflow_Continue AsyncChild2 {
    get => new SignatureOutflow_Continue(_Handle + Schema.GetOffset(0xB412A2592BEBF5F7));
  }
  public ISignatureOutflow_Resume YieldResume1 {
    get => new SignatureOutflow_Resume(_Handle + Schema.GetOffset(0xB412A2596063DFA8));
  }
  public ISignatureOutflow_Resume YieldResume2 {
    get => new SignatureOutflow_Resume(_Handle + Schema.GetOffset(0xB412A2596363E461));
  }


}