using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseGraphInstanceID_t : SchemaClass, IPulseGraphInstanceID_t {

  public PulseGraphInstanceID_t(nint handle) : base(handle) {
  }

  public ref uint Value {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x4291F7FFDCB0894A));
  }


}