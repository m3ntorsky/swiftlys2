using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPathMetricEvaluator : CMotionMetricEvaluator, IPathMetricEvaluator {

  public CPathMetricEvaluator(nint handle) : base(handle) {
  }

  public CPathMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< float32 > PathTimeSamples {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x6BF20F3A94DC552A));
  }
  public ref float Distance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6BF20F3A00DC4A68));
  }
  public ref bool ExtrapolateMovement {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6BF20F3ACBEE3025));
  }
  public ref float MinExtrapolationSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6BF20F3A9F6FB95C));
  }


}