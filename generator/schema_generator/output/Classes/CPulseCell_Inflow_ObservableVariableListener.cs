using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_ObservableVariableListener : CPulseCell_Inflow_BaseEntrypoint, IPulseCell_Inflow_ObservableVariableListener {

  public CPulseCell_Inflow_ObservableVariableListener(nint handle) : base(handle) {
  }

  public IPulseRuntimeBlackboardReferenceIndex_t BlackboardReference {
    get => new PulseRuntimeBlackboardReferenceIndex_t(_Handle + Schema.GetOffset(0x6186DA17C5B268D));
  }
  public ref bool SelfReference {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6186DA14772CFC4));
  }


}