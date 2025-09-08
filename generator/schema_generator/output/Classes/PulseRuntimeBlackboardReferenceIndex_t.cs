using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeBlackboardReferenceIndex_t : SchemaClass, IPulseRuntimeBlackboardReferenceIndex_t {

  public PulseRuntimeBlackboardReferenceIndex_t(nint handle) : base(handle) {
  }

  public ref short Value {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xE01C0CE3DCB0894A));
  }


}