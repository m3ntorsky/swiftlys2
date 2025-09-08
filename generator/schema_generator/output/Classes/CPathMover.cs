using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathMover : CPathSimple, IPathMover {

  public CPathMover(nint handle) : base(handle) {
  }

  public ref CUtlVector<CHandle<CMoverPathNode>> PathNodes {
    get => ref _Handle.AsRef<CUtlVector<CHandle<CMoverPathNode>>>(Schema.GetOffset(0x459CE4C6FD746CE3));
  }
  public ref CUtlVector<CHandle<CFuncMover>> Movers {
    get => ref _Handle.AsRef<CUtlVector<CHandle<CFuncMover>>>(Schema.GetOffset(0x459CE4C65C9C4C93));
  }
  public ref CTransform XInitialPathWorldToLocal {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x459CE4C6FE5D385E));
  }


}