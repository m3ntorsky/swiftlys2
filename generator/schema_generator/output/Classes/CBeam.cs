using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBeam : CBaseModelEntity, IBeam {

  public CBeam(nint handle) : base(handle) {
  }

  public IGameTime_t FireTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x4BCF3CE5873CD172));
  }
  public ref float Damage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4BCF3CE5DC60E53E));
  }
  public CHandle<IBaseEntity> EndEntity {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x4BCF3CE561070A9F));
  }
  public ref int DissolveType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4BCF3CE579AB525E));
  }

  public void FrameRateUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE574BE5A46);
  }
  public void HDRColorScaleUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5C930B3E8);
  }
  public void NumBeamEntsUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5D7D7CDFA);
  }
  public void BaseMaterialUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE55B164FBF);
  }
  public void HaloIndexUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5F6B595E1);
  }
  public void BeamTypeUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5E65D2926);
  }
  public void BeamFlagsUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5BB875091);
  }
  public void AttachEntityUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE56BCDCAD1);
  }
  public void AttachIndexUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5502E5BEC);
  }
  public void WidthUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE55A6716D3);
  }
  public void EndWidthUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE531E2A13A);
  }
  public void FadeLengthUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5BDBE91AF);
  }
  public void HaloScaleUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5E01B893B);
  }
  public void AmplitudeUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE56B89E71E);
  }
  public void StartFrameUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5EE6DF5C0);
  }
  public void SpeedUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5288671E4);
  }
  public void FrameUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5F836C9F4);
  }
  public void ClipStyleUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE51A311350);
  }
  public void TurnedOffUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE5EC469948);
  }
  public void EndPosUpdated() {
    Schema.Update(_Handle, 0x4BCF3CE58DD24760);
  }
}