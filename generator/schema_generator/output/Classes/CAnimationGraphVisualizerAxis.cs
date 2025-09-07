using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimationGraphVisualizerAxis : CAnimationGraphVisualizerPrimitiveBase, IAnimationGraphVisualizerAxis {

  public CAnimationGraphVisualizerAxis(nint handle) : base(handle) {
  }

  public CAnimationGraphVisualizerAxis(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CTransform XWsTransform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xB0A274E9AE1478FF));
  }
  public ref float AxisSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB0A274E9224B2A23));
  }


}