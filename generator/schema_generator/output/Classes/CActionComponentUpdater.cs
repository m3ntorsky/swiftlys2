using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CActionComponentUpdater : CAnimComponentUpdater, IActionComponentUpdater {

  public CActionComponentUpdater(nint handle) : base(handle) {
  }

  public ref CUtlVector Actions {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA700EA248D622684));
  }


}