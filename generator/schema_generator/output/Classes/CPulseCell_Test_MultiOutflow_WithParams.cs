using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Test_MultiOutflow_WithParams : CPulseCell_BaseFlow, IPulseCell_Test_MultiOutflow_WithParams {

  public CPulseCell_Test_MultiOutflow_WithParams(nint handle) : base(handle) {
  }

  public CPulseCell_Test_MultiOutflow_WithParams(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISignatureOutflow_Continue Out1 {
    get => new SignatureOutflow_Continue(_Handle + Schema.GetOffset(0x99BFB89905F293AA));
  }
  public ISignatureOutflow_Continue Out2 {
    get => new SignatureOutflow_Continue(_Handle + Schema.GetOffset(0x99BFB89904F29217));
  }


}