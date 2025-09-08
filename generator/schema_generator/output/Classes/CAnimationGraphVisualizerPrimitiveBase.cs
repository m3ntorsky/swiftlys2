using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimationGraphVisualizerPrimitiveBase : SchemaClass, IAnimationGraphVisualizerPrimitiveBase {

  public CAnimationGraphVisualizerPrimitiveBase(nint handle) : base(handle) {
  }

  public ref CAnimationGraphVisualizerPrimitiveType Type {
    get => ref _Handle.AsRef<CAnimationGraphVisualizerPrimitiveType>(Schema.GetOffset(0x5204B0848ED6D5CD));
  }
  public IAnimNodeID OwningAnimNodePaths {
    get => new AnimNodeID(_Handle, 0x5204B08461A2E55C, 11, 4, 4);
  }
  public ref int OwningAnimNodePathCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5204B0844241A972));
  }


}