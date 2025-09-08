using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NmPercent_t : SchemaClass, INmPercent_t {

  public NmPercent_t(nint handle) : base(handle) {
  }

  public ref float Value {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF12966B68DFCB984));
  }


}