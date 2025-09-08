using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavVolumeBreadthFirstSearch : CNavVolumeCalculatedVector, INavVolumeBreadthFirstSearch {

  public CNavVolumeBreadthFirstSearch(nint handle) : base(handle) {
  }

  public ref Vector StartPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x7C16FC090FE14C1B));
  }
  public ref float SearchDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7C16FC098227285F));
  }


}