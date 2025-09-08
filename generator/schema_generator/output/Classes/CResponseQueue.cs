using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CResponseQueue : SchemaClass, IResponseQueue {

  public CResponseQueue(nint handle) : base(handle) {
  }

  public ref CUtlVector<PointerTo<CAI_Expresser>> ExpresserTargets {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CAI_Expresser>>>(Schema.GetOffset(0xBA9C485870CCA05A));
  }


}