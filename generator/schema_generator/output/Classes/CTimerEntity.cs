using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTimerEntity : CLogicalEntity, ITimerEntity {

  public CTimerEntity(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnTimer {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE96486ECF7551DA1));
  }
  public IEntityIOOutput OnTimerHigh {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE96486ECEAFE5EC1));
  }
  public IEntityIOOutput OnTimerLow {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE96486EC60BA6A4D));
  }
  public ref int Disabled {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE96486EC51B3CEAC));
  }
  public ref float InitialDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE96486ECE025AE70));
  }
  public ref float RefireTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE96486ECEABAD29B));
  }
  public ref bool UpDownState {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE96486EC42D72911));
  }
  public ref int UseRandomTime {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE96486ECEBBE5799));
  }
  public ref bool PauseAfterFiring {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE96486EC767C1C9E));
  }
  public ref float LowerRandomBound {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE96486EC88350771));
  }
  public ref float UpperRandomBound {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE96486ECB238933E));
  }
  public ref float RemainingTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE96486EC88B29520));
  }
  public ref bool Paused {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE96486EC6E4C592B));
  }


}