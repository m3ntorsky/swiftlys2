using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CActionComponentUpdater : CAnimComponentUpdater, IActionComponentUpdater {

  public CActionComponentUpdater(nint handle) : base(handle) {
  }

  public CActionComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSmartPtr< CAnimActionUpdater > > Actions {
    get => ref _Handle.AsRef<CUtlVector< CSmartPtr< CAnimActionUpdater > >>(Schema.GetOffset(0xA700EA248D622684));
  }


}