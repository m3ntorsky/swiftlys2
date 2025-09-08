using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStepsRemainingMetricEvaluator : CMotionMetricEvaluator, IStepsRemainingMetricEvaluator {

  public CStepsRemainingMetricEvaluator(nint handle) : base(handle) {
  }

  public ref CUtlVector<int> FootIndices {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0xDDD8E3884C840316));
  }
  public ref float MinStepsRemaining {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDDD8E388382CE1FC));
  }


}