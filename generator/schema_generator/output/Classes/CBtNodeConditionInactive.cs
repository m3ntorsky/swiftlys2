using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBtNodeConditionInactive : CBtNodeCondition, IBtNodeConditionInactive {

  public CBtNodeConditionInactive(nint handle) : base(handle) {
  }

  public ref float RoundStartThresholdSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1AB44FB08A52CC47));
  }
  public ref float SensorInactivityThresholdSeconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1AB44FB07E66A29F));
  }
  public ICountdownTimer SensorInactivityTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1AB44FB0D921DF72));
  }


}