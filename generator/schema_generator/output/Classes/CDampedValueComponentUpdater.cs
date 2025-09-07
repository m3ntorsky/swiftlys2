using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDampedValueComponentUpdater : CAnimComponentUpdater, IDampedValueComponentUpdater {

  public CDampedValueComponentUpdater(nint handle) : base(handle) {
  }

  public CDampedValueComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CDampedValueUpdateItem > Items {
    get => ref _Handle.AsRef<CUtlVector< CDampedValueUpdateItem >>(Schema.GetOffset(0x9FFDDC9E7A87EDAF));
  }


}