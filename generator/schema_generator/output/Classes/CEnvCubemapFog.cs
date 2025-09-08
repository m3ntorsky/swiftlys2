using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvCubemapFog : CBaseEntity, IEnvCubemapFog {

  public CEnvCubemapFog(nint handle) : base(handle) {
  }

  public ref bool FirstTime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x38A7692ED23C3138));
  }

  public void EndDistanceUpdated() {
    Schema.Update(_Handle, 0x38A7692EB825C247);
  }
  public void StartDistanceUpdated() {
    Schema.Update(_Handle, 0x38A7692E796C8142);
  }
  public void FogFalloffExponentUpdated() {
    Schema.Update(_Handle, 0x38A7692E2068A39A);
  }
  public void HeightFogEnabledUpdated() {
    Schema.Update(_Handle, 0x38A7692EFB7ED9F7);
  }
  public void FogHeightWidthUpdated() {
    Schema.Update(_Handle, 0x38A7692E07936DE2);
  }
  public void FogHeightEndUpdated() {
    Schema.Update(_Handle, 0x38A7692E16176853);
  }
  public void FogHeightStartUpdated() {
    Schema.Update(_Handle, 0x38A7692ED4580CB6);
  }
  public void FogHeightExponentUpdated() {
    Schema.Update(_Handle, 0x38A7692E0864DD39);
  }
  public void LODBiasUpdated() {
    Schema.Update(_Handle, 0x38A7692E6917C8A7);
  }
  public void ActiveUpdated() {
    Schema.Update(_Handle, 0x38A7692E8334208F);
  }
  public void StartDisabledUpdated() {
    Schema.Update(_Handle, 0x38A7692E61ED0C4F);
  }
  public void FogMaxOpacityUpdated() {
    Schema.Update(_Handle, 0x38A7692E7BF7FD56);
  }
  public void CubemapSourceTypeUpdated() {
    Schema.Update(_Handle, 0x38A7692E30B17317);
  }
  public void SkyMaterialUpdated() {
    Schema.Update(_Handle, 0x38A7692EC887319D);
  }
  public void SkyEntityUpdated() {
    Schema.Update(_Handle, 0x38A7692E2BD44B1D);
  }
  public void FogCubemapTextureUpdated() {
    Schema.Update(_Handle, 0x38A7692E3470DA4D);
  }
  public void HasHeightFogEndUpdated() {
    Schema.Update(_Handle, 0x38A7692E3484C961);
  }
}