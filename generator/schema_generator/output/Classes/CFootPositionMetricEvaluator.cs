using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootPositionMetricEvaluator : CMotionMetricEvaluator, IFootPositionMetricEvaluator {

  public CFootPositionMetricEvaluator(nint handle) : base(handle) {
  }

  public CFootPositionMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< int32 > FootIndices {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x67E807C64C840316));
  }
  public ref bool IgnoreSlope {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x67E807C6541E43F2));
  }


}