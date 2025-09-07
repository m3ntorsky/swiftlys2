using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneVelocityMetricEvaluator : CMotionMetricEvaluator, IBoneVelocityMetricEvaluator {

  public CBoneVelocityMetricEvaluator(nint handle) : base(handle) {
  }

  public CBoneVelocityMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x90D313709F407B79));
  }


}