using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeConstantIndex_t : SchemaClass, IPulseRuntimeConstantIndex_t {

  public PulseRuntimeConstantIndex_t(nint handle) : base(handle) {
  }

  public ref short Value {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xCEAFE609DCB0894A));
  }


}