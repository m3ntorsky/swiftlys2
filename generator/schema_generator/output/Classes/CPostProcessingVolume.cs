using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPostProcessingVolume : CBaseTrigger, IPostProcessingVolume {

  public CPostProcessingVolume(nint handle) : base(handle) {
  }



  public void PostSettingsUpdated() {
    Schema.Update(_Handle, 0x5DBC28C1D2EB75A4);
  }
  public void FadeDurationUpdated() {
    Schema.Update(_Handle, 0x5DBC28C1C4E6DEE1);
  }
  public void MinLogExposureUpdated() {
    Schema.Update(_Handle, 0x5DBC28C17457F7D0);
  }
  public void MaxLogExposureUpdated() {
    Schema.Update(_Handle, 0x5DBC28C1DC5D3ED6);
  }
  public void MinExposureUpdated() {
    Schema.Update(_Handle, 0x5DBC28C122FAB634);
  }
  public void MaxExposureUpdated() {
    Schema.Update(_Handle, 0x5DBC28C15D4951D6);
  }
  public void ExposureCompensationUpdated() {
    Schema.Update(_Handle, 0x5DBC28C16EC15498);
  }
  public void ExposureFadeSpeedUpUpdated() {
    Schema.Update(_Handle, 0x5DBC28C19789BBB6);
  }
  public void ExposureFadeSpeedDownUpdated() {
    Schema.Update(_Handle, 0x5DBC28C154685D1F);
  }
  public void TonemapEVSmoothingRangeUpdated() {
    Schema.Update(_Handle, 0x5DBC28C19C2546CB);
  }
  public void MasterUpdated() {
    Schema.Update(_Handle, 0x5DBC28C15AFF9193);
  }
  public void ExposureControlUpdated() {
    Schema.Update(_Handle, 0x5DBC28C12C195925);
  }
}