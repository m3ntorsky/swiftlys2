using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseNodeDynamicOutflows_t : SchemaClass, IPulseNodeDynamicOutflows_t {

  public PulseNodeDynamicOutflows_t(nint handle) : base(handle) {
  }

  public PulseNodeDynamicOutflows_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< PulseNodeDynamicOutflows_t::DynamicOutflow_t > Outflows {
    get => ref _Handle.AsRef<CUtlVector< PulseNodeDynamicOutflows_t::DynamicOutflow_t >>(Schema.GetOffset(0x3F600DF58F0AFDF8));
  }


}