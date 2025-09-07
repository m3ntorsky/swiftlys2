using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBonePositionMetricEvaluator : CMotionMetricEvaluator, IBonePositionMetricEvaluator {

  public CBonePositionMetricEvaluator(nint handle) : base(handle) {
  }

  public CBonePositionMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB36923389F407B79));
  }


}