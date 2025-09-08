using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseNodeDynamicOutflows_t : SchemaClass, IPulseNodeDynamicOutflows_t {

  public PulseNodeDynamicOutflows_t(nint handle) : base(handle) {
  }

  public ref CUtlVector Outflows {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x3F600DF58F0AFDF8));
  }


}