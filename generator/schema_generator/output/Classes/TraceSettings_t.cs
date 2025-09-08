using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class TraceSettings_t : SchemaClass, ITraceSettings_t {

  public TraceSettings_t(nint handle) : base(handle) {
  }

  public ref float TraceHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6983A048EFB858CF));
  }
  public ref float TraceRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6983A0489A33E452));
  }


}