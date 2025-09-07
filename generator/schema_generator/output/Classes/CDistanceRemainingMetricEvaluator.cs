using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDistanceRemainingMetricEvaluator : CMotionMetricEvaluator, IDistanceRemainingMetricEvaluator {

  public CDistanceRemainingMetricEvaluator(nint handle) : base(handle) {
  }

  public CDistanceRemainingMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MaxDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEF12BCC898893360));
  }
  public ref float MinDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEF12BCC892BCAD06));
  }
  public ref float StartGoalFilterDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEF12BCC8531B6E2B));
  }
  public ref float MaxGoalOvershootScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEF12BCC8D2E0A335));
  }
  public ref bool FilterFixedMinDistance {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEF12BCC85AD937B2));
  }
  public ref bool FilterGoalDistance {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEF12BCC8A9641DB3));
  }
  public ref bool FilterGoalOvershoot {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEF12BCC89A875DD1));
  }


}