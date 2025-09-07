using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTimeRemainingMetricEvaluator : CMotionMetricEvaluator, ITimeRemainingMetricEvaluator {

  public CTimeRemainingMetricEvaluator(nint handle) : base(handle) {
  }

  public CTimeRemainingMetricEvaluator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool MatchByTimeRemaining {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAB802C86BB70462E));
  }
  public ref float MaxTimeRemaining {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAB802C8686818AD6));
  }
  public ref bool FilterByTimeRemaining {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAB802C8668E9E5BD));
  }
  public ref float MinTimeRemaining {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAB802C8604DD377C));
  }


}