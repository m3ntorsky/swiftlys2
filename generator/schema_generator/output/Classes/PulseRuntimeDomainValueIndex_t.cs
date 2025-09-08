using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeDomainValueIndex_t : SchemaClass, IPulseRuntimeDomainValueIndex_t {

  public PulseRuntimeDomainValueIndex_t(nint handle) : base(handle) {
  }

  public ref short Value {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xCA672082DCB0894A));
  }


}