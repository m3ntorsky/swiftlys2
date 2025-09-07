using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRemapValueComponentUpdater : CAnimComponentUpdater, IRemapValueComponentUpdater {

  public CRemapValueComponentUpdater(nint handle) : base(handle) {
  }

  public CRemapValueComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CRemapValueUpdateItem > Items {
    get => ref _Handle.AsRef<CUtlVector< CRemapValueUpdateItem >>(Schema.GetOffset(0xA80D46C07A87EDAF));
  }


}