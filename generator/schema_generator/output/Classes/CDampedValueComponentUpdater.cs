using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDampedValueComponentUpdater : CAnimComponentUpdater, IDampedValueComponentUpdater {

  public CDampedValueComponentUpdater(nint handle) : base(handle) {
  }

  public ref CUtlVector Items {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x9FFDDC9E7A87EDAF));
  }


}