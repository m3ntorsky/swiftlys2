using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootCycleMetricEvaluator : CMotionMetricEvaluator, IFootCycleMetricEvaluator {

  public CFootCycleMetricEvaluator(nint handle) : base(handle) {
  }

  public CFootCycleMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< int32 > FootIndices {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x1773C1814C840316));
  }


}