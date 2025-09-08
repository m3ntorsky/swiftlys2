using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseNodeDynamicOutflows_t__DynamicOutflow_t : SchemaClass, IPulseNodeDynamicOutflows_t__DynamicOutflow_t {

  public PulseNodeDynamicOutflows_t__DynamicOutflow_t(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol OutflowID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x4ACC8D59E16DD56));
  }
  public IPulse_OutflowConnection Connection {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x4ACC8D5D4CD5F59));
  }


}