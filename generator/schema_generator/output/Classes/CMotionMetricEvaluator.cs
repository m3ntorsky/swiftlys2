using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionMetricEvaluator : SchemaClass, IMotionMetricEvaluator {

  public CMotionMetricEvaluator(nint handle) : base(handle) {
  }

  public CMotionMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< float32 > Means {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x1C07D08DAB070085));
  }
  public ref CUtlVector< float32 > StandardDeviations {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x1C07D08D9114EB60));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1C07D08D7B81E7AB));
  }
  public ref int DimensionStartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1C07D08D3448F2E3));
  }


}