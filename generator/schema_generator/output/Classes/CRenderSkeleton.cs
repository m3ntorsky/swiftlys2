using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRenderSkeleton : SchemaClass, IRenderSkeleton {

  public CRenderSkeleton(nint handle) : base(handle) {
  }

  public ref CUtlVector Bones {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xBF0A83950FDA60D4));
  }
  public ref CUtlVector<int> BoneParents {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0xBF0A839571828F04));
  }
  public ref int BoneWeightCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBF0A839508029166));
  }


}