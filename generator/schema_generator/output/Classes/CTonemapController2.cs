using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTonemapController2 : CBaseEntity, ITonemapController2 {

  public CTonemapController2(nint handle) : base(handle) {
  }

  public CTonemapController2(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float AutoExposureMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD2B5E9D27D8FC60B));
  }
  public ref float AutoExposureMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD2B5E9D2937C60F5));
  }
  public ref float ExposureAdaptationSpeedUp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD2B5E9D2D587708B));
  }
  public ref float ExposureAdaptationSpeedDown {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD2B5E9D232DAF29E));
  }
  public ref float TonemapEVSmoothingRange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD2B5E9D29C2546CB));
  }

  public void AutoExposureMinUpdated() {
    Schema.Update(_Handle, 0xD2B5E9D27D8FC60B);
  }
  public void AutoExposureMaxUpdated() {
    Schema.Update(_Handle, 0xD2B5E9D2937C60F5);
  }
  public void ExposureAdaptationSpeedUpUpdated() {
    Schema.Update(_Handle, 0xD2B5E9D2D587708B);
  }
  public void ExposureAdaptationSpeedDownUpdated() {
    Schema.Update(_Handle, 0xD2B5E9D232DAF29E);
  }
  public void TonemapEVSmoothingRangeUpdated() {
    Schema.Update(_Handle, 0xD2B5E9D29C2546CB);
  }
}