using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CColorCorrectionVolume : CBaseTrigger, IColorCorrectionVolume {

  public CColorCorrectionVolume(nint handle) : base(handle) {
  }

  public ref float LastEnterWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x78A9E01B2F53D64D));
  }
  public IGameTime_t LastEnterTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x78A9E01B01977F10));
  }
  public ref float LastExitWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x78A9E01B59C9642D));
  }
  public IGameTime_t LastExitTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x78A9E01B183C8DF0));
  }

  public void MaxWeightUpdated() {
    Schema.Update(_Handle, 0x78A9E01BEE8A2F2D);
  }
  public void FadeDurationUpdated() {
    Schema.Update(_Handle, 0x78A9E01B46550027);
  }
  public void WeightUpdated() {
    Schema.Update(_Handle, 0x78A9E01BBF415739);
  }
  public void LookupFilenameUpdated() {
    Schema.Update(_Handle, 0x78A9E01B2611A2C6);
  }
}