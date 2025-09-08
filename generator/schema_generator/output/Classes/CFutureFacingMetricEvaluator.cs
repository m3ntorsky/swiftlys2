using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFutureFacingMetricEvaluator : CMotionMetricEvaluator, IFutureFacingMetricEvaluator {

  public CFutureFacingMetricEvaluator(nint handle) : base(handle) {
  }

  public ref float Distance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A3CD0D400DC4A68));
  }
  public ref float Time {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A3CD0D4C957229E));
  }


}