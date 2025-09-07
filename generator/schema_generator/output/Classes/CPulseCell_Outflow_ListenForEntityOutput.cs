using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_ListenForEntityOutput : CPulseCell_BaseYieldingInflow, IPulseCell_Outflow_ListenForEntityOutput {

  public CPulseCell_Outflow_ListenForEntityOutput(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_ListenForEntityOutput(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISignatureOutflow_Resume OnFired {
    get => new SignatureOutflow_Resume(_Handle + Schema.GetOffset(0xCB35163784825730));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xCB351637F02162DB));
  }
  public ref CGlobalSymbol StrEntityOutput {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xCB351637C8E70456));
  }
  public ref CUtlString StrEntityOutputParam {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xCB351637BB356637));
  }
  public ref bool ListenUntilCanceled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCB351637C798285D));
  }


}