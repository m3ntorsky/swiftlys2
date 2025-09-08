using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvParticleGlow : CParticleSystem, IEnvParticleGlow {

  public CEnvParticleGlow(nint handle) : base(handle) {
  }



  public void AlphaScaleUpdated() {
    Schema.Update(_Handle, 0x38100F3AEC6D3C25);
  }
  public void RadiusScaleUpdated() {
    Schema.Update(_Handle, 0x38100F3AA7A20159);
  }
  public void SelfIllumScaleUpdated() {
    Schema.Update(_Handle, 0x38100F3A0478CE14);
  }
  public void ColorTintUpdated() {
    Schema.Update(_Handle, 0x38100F3AD55CDDFD);
  }
  public void TextureOverrideUpdated() {
    Schema.Update(_Handle, 0x38100F3AEC1F5A56);
  }
}