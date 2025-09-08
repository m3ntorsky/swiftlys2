using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRemapValueComponentUpdater : CAnimComponentUpdater, IRemapValueComponentUpdater {

  public CRemapValueComponentUpdater(nint handle) : base(handle) {
  }

  public ref CUtlVector Items {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA80D46C07A87EDAF));
  }


}