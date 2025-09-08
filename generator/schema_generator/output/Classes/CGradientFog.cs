using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGradientFog : CBaseEntity, IGradientFog {

  public CGradientFog(nint handle) : base(handle) {
  }

  public ref bool GradientFogNeedsTextures {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x978D360E55F47008));
  }

  public void GradientFogTextureUpdated() {
    Schema.Update(_Handle, 0x978D360E547F825C);
  }
  public void FogStartDistanceUpdated() {
    Schema.Update(_Handle, 0x978D360E4B5A1DBC);
  }
  public void FogEndDistanceUpdated() {
    Schema.Update(_Handle, 0x978D360E27F71D5D);
  }
  public void HeightFogEnabledUpdated() {
    Schema.Update(_Handle, 0x978D360EFB7ED9F7);
  }
  public void FogStartHeightUpdated() {
    Schema.Update(_Handle, 0x978D360E34EA384C);
  }
  public void FogEndHeightUpdated() {
    Schema.Update(_Handle, 0x978D360E6644141D);
  }
  public void FarZUpdated() {
    Schema.Update(_Handle, 0x978D360E38F5E41A);
  }
  public void FogMaxOpacityUpdated() {
    Schema.Update(_Handle, 0x978D360E7BF7FD56);
  }
  public void FogFalloffExponentUpdated() {
    Schema.Update(_Handle, 0x978D360E2068A39A);
  }
  public void FogVerticalExponentUpdated() {
    Schema.Update(_Handle, 0x978D360EBBE3E0C4);
  }
  public void FogColorUpdated() {
    Schema.Update(_Handle, 0x978D360E200EEE0E);
  }
  public void FogStrengthUpdated() {
    Schema.Update(_Handle, 0x978D360E2DCA8F14);
  }
  public void FadeTimeUpdated() {
    Schema.Update(_Handle, 0x978D360E00BEDB08);
  }
  public void StartDisabledUpdated() {
    Schema.Update(_Handle, 0x978D360E61ED0C4F);
  }
  public void IsEnabledUpdated() {
    Schema.Update(_Handle, 0x978D360E5360D70E);
  }
}