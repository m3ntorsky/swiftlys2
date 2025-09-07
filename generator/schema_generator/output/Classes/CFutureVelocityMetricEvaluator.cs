using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFutureVelocityMetricEvaluator : CMotionMetricEvaluator, IFutureVelocityMetricEvaluator {

  public CFutureVelocityMetricEvaluator(nint handle) : base(handle) {
  }

  public CFutureVelocityMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Distance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF0A3A8300DC4A68));
  }
  public ref float StoppingDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF0A3A8324979434));
  }
  public ref float TargetSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF0A3A839C627845));
  }
  public ref VelocityMetricMode Mode {
    get => ref _Handle.AsRef<VelocityMetricMode>(Schema.GetOffset(0xF0A3A831050A633));
  }


}