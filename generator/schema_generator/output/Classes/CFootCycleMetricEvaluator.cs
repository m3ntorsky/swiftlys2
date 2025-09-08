using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootCycleMetricEvaluator : CMotionMetricEvaluator, IFootCycleMetricEvaluator {

  public CFootCycleMetricEvaluator(nint handle) : base(handle) {
  }

  public ref CUtlVector<int> FootIndices {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0x1773C1814C840316));
  }


}